using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public class ProductsAndRequestManager
    {
        List<Department> departments = new List<Department>();
        List<Products> products = new List<Products>();
        List<ProductRequest> productRequests = new List<ProductRequest>();
        private DBConnectionClass DBConnectionClass;

        public ProductsAndRequestManager()
        {
            DBConnectionClass = new DBConnectionClass();
            loadDataFromDataBaseDepartment();
        }
 
    
        public void loadDataFromDataBaseDepartment()
        {
            this.departments = new List<Department>();
            foreach (Department department in (List<Department>)DBConnectionClass.ReadAllFromDepartment())
            {
                this.departments.Add((Department)department);
            }
        }
        public List<string> GetManagerNames()
        {
            string sql = "SELECT e.FirstName,e.Surname FROM employee as e INNER JOIN role as r ON e.Role=r.RoleID WHERE r.AcessLevel>4;";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnectionClass.conn);
            List<string> ManagerNames = this.DBConnectionClass.ReadEmployeeNames(cmd);

            return ManagerNames;
        }
        public List<string> GetDepartmentNames()
        {
            string sql = "SELECT d.DepartmentName FROM department as d INNER JOIN products as p ON d.DepartmentName=p.DepartmentID;";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnectionClass.conn);
            List<string> DepartmentNames = this.DBConnectionClass.ReadDepartmentNames(cmd);

            return DepartmentNames;
        }
        
  
        public void Add(Department department)
        {
            int n = 0;
            try
            {
                n = DBConnectionClass.InsertDepartment((Department)department);
                if (n == 0)
                {
                    MessageBox.Show("Failed to add department");
                }
                else
                {
                    loadDataFromDataBaseDepartment();
                }

            }
            catch (AddingToDBFailedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Department FindDepartment(string departmentName)
        {
            foreach (Department d in departments)
            {
                if(d.GetDepartmentName() == departmentName)
                {
                    return d;
                }
            }
            return null;
        }

        public Department FindDepartmentByID(int departmentID)
        {
            foreach (Department d in departments)
            {
                if (d.GetDepartmentID() == departmentID)
                {
                    return d;
                }
            }
            return null;
        }

        public List<Products> GetAllProducts()
        {
            return this.products;
        }
        public List<ProductRequest> GetAllProductRequest()
        {
            return this.productRequests;
        }
        public List<Department> GetAllDepartments()
        {
            return this.departments;
        }
        

        public void UpdateProductsList()
        {
            this.products = this.DBConnectionClass.ReadAllFromProducts();

        }
        //make an item in products inactive
        public void DeleteProduct(Products p)
        {
            if (p.Quantity == 0)
            {
                this.DBConnectionClass.DeleteProduct(p.ProductID);
            }
            else
            {
                MessageBox.Show("Product is not out of stock yet! Try again after all the items have been sold.");
            }
        }
        //update data about product
        public void UpdateProduct(int prodID, string productName, int quantity, string productDescription, decimal buyingPrice, decimal sellingPrice, int depID, string code)
        {
            this.DBConnectionClass.UpdateProduct(prodID, productName, quantity, productDescription, buyingPrice, sellingPrice, depID, code);
        }
        //create a new product
        public void CreateProduct(string productName, int quantity, string productDescription, decimal buyingPrice, decimal sellingPrice, int depID, string code)
        {
            this.DBConnectionClass.CreateProduct(productName, quantity, productDescription, buyingPrice, sellingPrice, depID, code);
        }
        //sell product
        public void SellProduct(int id, int sell)
        {

            int quantity = 0;
            string name = "";
            foreach (Products p in products)
            {
                if (p.ProductID == id)
                {
                    quantity = p.Quantity;
                    name = p.ProductName;
                    break;
                }
            }
            if (quantity - sell < 0 && quantity != 0)
            {
                MessageBox.Show("You are trying to sell more items than are curently available. \n All stock will has been sold!", "Selling problem", MessageBoxButtons.OK);
                this.DBConnectionClass.SellProduct(id, quantity);
                this.DBConnectionClass.UpdateQuantityProduct(id, 0);
            }
            else if (quantity == 0)
            {
                MessageBox.Show($"{name} is out of stock! \r \n Please restock before trying to sell more!", "Selling problem", MessageBoxButtons.OK);
            }
            else
            {
                this.DBConnectionClass.SellProduct(id, sell);
                this.DBConnectionClass.UpdateQuantityProduct(id, quantity - sell);
            }

        }
        //request products
        public void CreateRequest(int id, int quantity)
        {
            this.DBConnectionClass.CreateRequest(id, quantity);
            this.DBConnectionClass.Restock(id, quantity);
        }

    }
}

