using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HardwareStoreApp
{
    public class DBConnectionClass
    {
        public static MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid = dbi451361; Database = dbi451361; Pwd = bigballs; AllowUserVariables=True;");


       

        public List<Shift> ReadAllShiftsByDepartmentID(int depID)
        {
            //actual thing
            List<Shift> shifts = new List<Shift>();
            List<int> empids = new List<int>();
            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT s.ShiftID,s.Date,s.EmployeeID,s.ShiftType, s.DepartmentID FROM shift AS s INNER JOIN department AS d ON s.DepartmentID=d.DepartmentID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    empids.Add(Convert.ToInt32(dr[2]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " ReadAllShiftsByDepartmentID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ReadAllShiftsByDepartmentID");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            foreach (int id in empids)
            {
                employees.Add(GetEmployeeByID(id));
            }

            try
            {
                int counter = 0;
                string sql = "SELECT s.ShiftID,s.Date,s.EmployeeID,s.ShiftType, s.DepartmentID FROM shift AS s INNER JOIN department AS d ON s.DepartmentID=d.DepartmentID";
                //SELECT s.ShiftID,s.Date,s.EmployeeID,s.ShiftType FROM shift AS s INNER JOIN department AS d ON s.DepartmentID=d.DepartmentID
                //as s INNER JOIN department as d ON d.DepartmentID=s.DepartmentID
                //SELECT * FROM shifts AS s INNER JOIN employee AS e ON s.EmployeeID=e.EmployeeID
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Employee emp = employees[counter];
                    DateTime date = Convert.ToDateTime(dr[1]);
                    ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), Convert.ToString(dr[3]));
                    if (depID == Convert.ToInt32(dr[4]))
                    {
                        shifts.Add(new Shift(date, shiftenum, emp));
                    }
                    counter++;
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return shifts;
        }
        public List<UnavailableShift> ReadAllUnavailableShiftsByEmployeeID(int employeeID)
        {
            Employee emp = GetEmployeeByID(employeeID);
            List<UnavailableShift> unshifts = new List<UnavailableShift>();
            try
            {

                string sql = "SELECT * FROM unavailableshift";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), Convert.ToString(dr[3]));
                    DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Convert.ToString(dr[2]));
                    //if (emp.GetEmployeeID() == Convert.ToInt32(dr[1]))
                    //{
                    //    unshifts.Add(new UnavailableShift(shiftenum, dayOfWeek));
                    //}

                    if (emp.GetEmployeeID() == Convert.ToInt32(dr[1]))
                    {
                        unshifts.Add(new UnavailableShift(shiftenum, dayOfWeek));
                        //employee.AddUnavailableShift(new UnavailableShift(shiftenum, dayOfWeek));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " ReadAllUnavailableShiftsByEmployeeID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ReadAllUnavailableShiftsByEmployeeID");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return unshifts;
        }
        public Employee GetEmployeeByID(int employeeID)
        {
            List<Employee> emps = new List<Employee>();
            try
            {

                string sql = "SELECT * FROM employee AS e INNER JOIN role AS r ON e.Role=r.RoleID WHERE EmployeeID= @EmployeeID";
                //as s INNER JOIN department as d ON d.DepartmentID=s.DepartmentID
                //string sql = "SELECT * FROM employees AS e INNER JOIN role AS r WHERE EmployeeID= @EmployeeID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emps.Add(new Employee(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[5]), Convert.ToString(dr[3]), Convert.ToString(dr[4]), Convert.ToInt32(dr[8]),
                       Convert.ToDecimal(dr[9]), Convert.ToInt32(dr[0]), Convert.ToDateTime(dr[7]), Convert.ToString(dr[6]),
                       new Role(Convert.ToInt32(dr[14]), Convert.ToString(dr[16]), Convert.ToInt32(dr[15])), Convert.ToDouble(dr[11]), Convert.ToInt32(dr[12]), Convert.ToInt32(dr[13])));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " GetEmployeeByID");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return emps[0];
        }
        public List<Employee> ReadAllFromEmployee()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                string sql = "SELECT * FROM employee as e INNER JOIN role as r ON e.Role=r.RoleID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    employees.Add(new Employee(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[5]), Convert.ToString(dr[3]), Convert.ToString(dr[4]), Convert.ToInt32(dr[8]),
                        Convert.ToDecimal(dr[9]), Convert.ToInt32(dr[0]), Convert.ToDateTime(dr[7]), Convert.ToString(dr[6]),
                        new Role(Convert.ToInt32(dr[14]), Convert.ToString(dr[16]), Convert.ToInt32(dr[15])), Convert.ToDouble(dr[11]), Convert.ToInt32(dr[12]), Convert.ToInt32(dr[13])));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading db! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return employees;
        }
        public List<string> ReadEmployeeNames(MySqlCommand cmd)
        {
            List<string> names = null;

            try
            {
                conn.Open();
                names = new List<string>();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    names.Add($"{Convert.ToString(dr[0])} {Convert.ToString(dr[1])}");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading db! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return names;
        }
        public List<string> ReadDepartmentNames(MySqlCommand cmd)
        {
            List<string> names = null;
            try
            {
                conn.Open();
                names = new List<string>();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    names.Add($"{Convert.ToString(dr[0])}");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading db! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return names;
        }     
        public Employee ReadWantedEmployee(MySqlCommand cmd)//subject to change when i add departmentID
        {
            Employee employee = null;
            try
            {

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    employee = new Employee(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[5]),
                    Convert.ToString(dr[3]), Convert.ToString(dr[4]), Convert.ToInt32(dr[8]), Convert.ToDecimal(dr[9]), Convert.ToInt32(dr[0]),
                    Convert.ToDateTime(dr[7]), Convert.ToString(dr[6]),
                    new Role(Convert.ToInt32(dr[12]), Convert.ToString(dr[14]), Convert.ToInt32(dr[13])), Convert.ToDouble(dr[11]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return employee;
        }
        public Role GetRole(long roleID)
        {
            string sql = "SELECT * FROM role WHERE RoleID=@RoleID";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnectionClass.conn);
            cmd.Parameters.AddWithValue("@RoleID", roleID);
            Role role = this.ReadOneRole(cmd);
            return role;
        }
        public List<Role> ReadAllFromRole()
        {
            List<Role> role = new List<Role>();
            try
            {
                string sql = "SELECT * FROM role";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    role.Add(new Role(Convert.ToInt32(dr[0]), dr[2].ToString(), Convert.ToInt32(dr[1])));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading roles db! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return role;
        }
        public Role ReadOneRole(MySqlCommand cmd)
        {
            Role role = null;
            try
            {

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    role = new Role(Convert.ToInt32(dr[0]), dr[2].ToString(), Convert.ToInt32(dr[1]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return role;
        }
        public List<Department> ReadAllFromDepartment()
        {
            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT * FROM department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Department department = new Department(Convert.ToString(dr[0]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), Convert.ToInt32(dr[1]));
                    //department.SetDepartmentID(Convert.ToInt32(dr[1]));
                    departments.Add(department);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading requests db! Try again. - ReadAllFromDepartment");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return departments;
        }



        public int InsertDepartment(Department department)
        {
            int affectedRows = 0;

            try
            {
                conn.Open();
                string sql = "INSERT INTO department (DepartmentName,DepartmentID,ManagerID,DepartmentDescription)" +
                    " VALUES (@DepartmentName,NULL,@ManagerID,@DepartmentDescription)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                cmd.Parameters.AddWithValue("@ManagerID", department.ManagerID);
                cmd.Parameters.AddWithValue("@DepartmentDescription", department.DepartmentDescription);

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return affectedRows;
        }
        public void InsertProductRequest(ProductRequest productRequest)
        {

            try
            {
                string sql = "INSERT INTO productrequest (RequestID,ProductID,Quantity,DemandedDate)" +
                   " VALUES (@requestID,@productID,@quantity,@DemandedDate)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", productRequest.RequestID);
                cmd.Parameters.AddWithValue("@demandedDate", productRequest.DemandedDate);
                cmd.Parameters.AddWithValue("@quantity", productRequest.Quantity);
                cmd.Parameters.AddWithValue("@productID", productRequest.ProductID);



                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public int InsertEmployee(Employee employee)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                string sql = "INSERT INTO employee (EmployeeID,FirstName,Surname,PhoneNumber,Address,EmailAddress,Password,DateOfBirth,BSN,HourlyWage,Role,Contract,Status,DepartmentID)" +
                    " VALUES (@employeeID,@FirstName,@Surname,@PhoneNumber,@Address,@EmailAddress,@Password,@DateOfBirth,@BSN,@HourlyWage,@Role,@Contract,@Status,@DepartmentID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", employee.GetFirstName());
                cmd.Parameters.AddWithValue("@Surname", employee.GetSurname());
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.GetPhoneNumber());
                cmd.Parameters.AddWithValue("@Address", employee.GetAddress());
                cmd.Parameters.AddWithValue("@EmailAddress", employee.GetEmailAddress());
                cmd.Parameters.AddWithValue("@Password", employee.GetPassword());
                cmd.Parameters.AddWithValue("@DateOfBirth", employee.GetDateOfBirth());
                cmd.Parameters.AddWithValue("@BSN", employee.GetBSN());
                cmd.Parameters.AddWithValue("@HourlyWage", employee.GetHourlyWage());
                cmd.Parameters.AddWithValue("@Role", employee.GetRoleID());
                cmd.Parameters.AddWithValue("@Contract", employee.GetContract());
                cmd.Parameters.AddWithValue("@Status", 1);
                cmd.Parameters.AddWithValue("@DepartmentID", employee.GetDepartmentID());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new AddingToDBFailedException(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return affectedRows;

        }
        public int InsertRole(Role role)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                string sql = "INSERT INTO role (RoleID,AcessLevel,RoleName)" +
                    " VALUES (@RoleID,@AcessLevel,@RoleName)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AcessLevel", role.GetAccessLevel());
                cmd.Parameters.AddWithValue("@RoleName", role.GetRoleName());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return affectedRows;

        }

        public void InsertShift(Shift s, Department d)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO shift (DepartmentID,ShiftType,Date,EmployeeID) VALUES (@DepartmentID, @ShiftType, @Date, @EmployeeID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DepartmentID",d.DepartmentID);
                cmd.Parameters.AddWithValue("@ShiftType", s.GetShiftType().ToString());
                cmd.Parameters.AddWithValue("@Date", s.GetDate().ToString());
                cmd.Parameters.AddWithValue("@EmployeeID", s.GetEmployee().GetEmployeeID());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " InsertShift");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" InsertShift");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public int UpdateRole(Role role)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                string sql = "UPDATE role SET AcessLevel= @AcessLevel,RoleName= @RoleName WHERE RoleID= @RoleID;"
                  ;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AcessLevel", role.GetAccessLevel());
                cmd.Parameters.AddWithValue("@RoleName", role.GetRoleName());
                cmd.Parameters.AddWithValue("@RoleID", role.GetRoleID());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return affectedRows;

        }
        public int UpdateEmployee(Employee employee)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                string sql = "UPDATE employee SET FirstName= @FirstName,Surname= @Surname,PhoneNumber= @PhoneNumber,Address= @Address," +
                    "EmailAddress= @EmailAddress,Password= @Password,DateOfBirth= @DateOfBirth,BSN= @BSN,HourlyWage= @HourlyWage,Contract= @Contract,Status= @Status,DepartmentID= @DepartmentID WHERE EmployeeID=@EmployeeID;"
                  ;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", employee.GetFirstName());
                cmd.Parameters.AddWithValue("@EmployeeID", employee.GetEmployeeID());
                cmd.Parameters.AddWithValue("@Surname", employee.GetSurname());
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.GetPhoneNumber());
                cmd.Parameters.AddWithValue("@Address", employee.GetAddress());
                cmd.Parameters.AddWithValue("@EmailAddress", employee.GetEmailAddress());
                cmd.Parameters.AddWithValue("@Password", employee.GetPassword());
                cmd.Parameters.AddWithValue("@DateOfBirth", employee.GetDateOfBirth());
                cmd.Parameters.AddWithValue("@BSN", employee.GetBSN());
                cmd.Parameters.AddWithValue("@HourlyWage", employee.GetHourlyWage());
                cmd.Parameters.AddWithValue("@Contract", employee.GetContract());
                cmd.Parameters.AddWithValue("@Status", employee.GetStatus());
                cmd.Parameters.AddWithValue("@DepartmentID", employee.GetDepartmentID());


                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new AddingToDBFailedException(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return affectedRows;

        }

        internal void RemoveShift(Shift s, Department d)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM shift WHERE DepartmentID=@DepartmentID AND ShiftType= @ShiftType AND Date=@Date AND EmployeeID=@EmployeeID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@DepartmentID", d.DepartmentID);
                cmd.Parameters.AddWithValue("@ShiftType", s.GetShiftType().ToString());
                cmd.Parameters.AddWithValue("@Date", s.GetDate().ToString());
                cmd.Parameters.AddWithValue("@EmployeeID", s.GetEmployee().GetEmployeeID());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " RemoveShift");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " RemoveShift");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private MySqlCommand command;
        private string query = "";
        public void AddWithValue(string parameterName, object value)
        {
            command.Parameters.AddWithValue(parameterName, value);
        }
        public void ExNonQuery()
        {
            command.ExecuteNonQuery();
        }
        public bool ConnOpen()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error!");
                return false;
            }
        }
        public void ConnClose()
        {
            conn.Close();
        }
        public void SqlQuery(string queryText)
        {
            command = new MySqlCommand(queryText, conn);
        }

        public List<Products> ReadAllFromProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                string sql = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Products product = new Products(Convert.ToInt32(dr["ProductID"]), Convert.ToString(dr["ProductName"]), Convert.ToInt32(dr["Quantity"]), Convert.ToString(dr["ProductDescription"]), Convert.ToDecimal(dr["BuyingPrice"]), Convert.ToDecimal(dr["SellingPrice"]), Convert.ToInt32(dr["DepartmentID"]), Convert.ToInt16(dr["Inactive"]), Convert.ToInt16(dr["Sold"]), Convert.ToString(dr["BarCode"]));
                    products.Add(product);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured reading products db! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }
        //change inactive to true = the product will not be displayed in current stock and the item is not available
        public bool DeleteProduct(int productId)
        {
            if (ConnOpen())
            {
                query = "UPDATE products SET Inactive= 1  WHERE products.ProductID = @prodID";
                SqlQuery(query);
                command.Parameters.AddWithValue("@prodID", productId);

                ExNonQuery();
                ConnClose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(int prodID, string productName, int quantity, string productDescription, decimal buyingPrice, decimal sellingPrice, int depID, string code)
        {
            if (ConnOpen())
            {

                query = "UPDATE Products SET productName= @productName, quantity = @quantity, productDescription = @productDescription, buyingPrice = @buyingPrice, " +
                    "sellingPrice = @sellingPrice, DepartmentID = @DepartmentID, BarCode = @code WHERE ProductID = @ProductID ";
                SqlQuery(query);

                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@productDescription", productDescription);
                command.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                command.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                command.Parameters.AddWithValue("@DepartmentID", depID);
                command.Parameters.AddWithValue("@ProductID", prodID);
                command.Parameters.AddWithValue("@code", code);

                ExNonQuery();
                ConnClose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateProduct(string productName, int quantity, string productDescription, decimal buyingPrice, decimal sellingPrice, int depID, string code)
        {
            if (ConnOpen())
            {
                query = "INSERT INTO products (ProductID, ProductName, Quantity, ProductDescription, BuyingPrice, SellingPrice, DepartmentID, Inactive, BarCode, Sold)" +
                        " VALUES (NULL, @productName, 0, @productDescription, @buyingPrice, @sellingPrice, @DepartmentID, 0, @code, 0)";
                SqlQuery(query);

                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@productDescription", productDescription);
                command.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                command.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                command.Parameters.AddWithValue("@DepartmentID", depID);
                command.Parameters.AddWithValue("@code", code);

                ExNonQuery();
                ConnClose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SellProduct(int id, int sell)
        {
            if (ConnOpen())
            {
                query = "UPDATE Products SET Sold = Sold + @sell WHERE ProductID = @id";
                SqlQuery(query);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@sell", sell);

                ExNonQuery();
                ConnClose();
            }
        }

        public void UpdateQuantityProduct(int id, int quantity)
        {
            if (ConnOpen())
            {
                query = "UPDATE Products SET Quantity = @quantity WHERE ProductID = @id";
                SqlQuery(query);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@quantity", quantity);

                ExNonQuery();
                ConnClose();
            }
        }


        public void Restock(int id, int quantity)
        {
            if (ConnOpen())
            {
                query = "UPDATE Products SET Quantity = Quantity + @quantity WHERE ProductID = @id";
                SqlQuery(query);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@quantity", quantity);

                ExNonQuery();
                ConnClose();
            }
        }

        public void CreateRequest(int id, int quantity)
        {
            if (ConnOpen())
            {
                query = "INSERT INTO productrequest (requestID, productID, Date, quantity) VALUES (NULL, @id, @date, @quantity)";
                SqlQuery(query);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@quantity", quantity);
                DateTime date = DateTime.Now;
                string d = date.ToShortDateString();
                command.Parameters.AddWithValue("@date", d);

                ExNonQuery();
                ConnClose();
            }
        }



    }
}







