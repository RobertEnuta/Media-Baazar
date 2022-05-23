using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HardwareStoreApp
{
    public partial class LogIn : Form
    {

        private Memory memory = new Memory();
        private EmployeeManager employeeManager = new EmployeeManager();//
        private DBConnectionClass DBConnectionClass = new DBConnectionClass();
        private RoleManager roleManager = new RoleManager();
        private DepartmentManager departmentManager = new DepartmentManager();
        private ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();//
        public LogIn()
        {

            InitializeComponent();
            employeeManager = memory.GetEmployeeManager();
           // departmentManager.AddDepartments((List<Department>)DBConnectionClass.ReadAllFromDepartment());


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool verification = false;
                List<Employee> employeeList = employeeManager.GetEmployees();
                foreach (Employee em in employeeList)
                {
                    if (em.GetEmailAddress() == tbUsername.Text)
                    {
                        if (em.GetPassword() == tbPassword.Text)
                        {
                            verification = true;
                            memory.SetEmployee(em);

                        }
                    }
                }
                if (verification == true)
                {
                    MenuForm menu = new MenuForm(memory, roleManager, employeeManager, productsAndRequestManager, departmentManager);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    throw new InvalidLoginDetailsException();
                }
            }
            catch (InvalidLoginDetailsException)
            {
                MessageBox.Show("Invalid login details! Please, try again!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }


        }


    }
}
