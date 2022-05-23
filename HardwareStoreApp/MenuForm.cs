using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public partial class MenuForm : Form
    {
        private Memory memory;
        private EmployeeManager employeeManager;
        private RoleManager roleManager;
        private Employee currentEmp;
        private ShiftManager shiftManager;
        private DepartmentManager departmentManager;
        private ProductsAndRequestManager productsAndRequestManager;
        private DBConnectionClass dbcon = new DBConnectionClass();


        // we gonna make employee manager invisible to employees who are logged in and probs gonna make my info invis to admin logged in

        public MenuForm(Memory memory, RoleManager roleManager, EmployeeManager employeeManager, ProductsAndRequestManager productsAndRequestManager, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.currentEmp = memory.GetEmployee();
            lblEmpInfo.Text = currentEmp.GetBasicInfo();
            this.employeeManager = employeeManager;
            shiftManager = memory.GetShiftManager();
            this.roleManager = roleManager;
            this.departmentManager = departmentManager;
            this.productsAndRequestManager = productsAndRequestManager;
            departmentManager.AddDepartments((List<Department>)dbcon.ReadAllFromDepartment());
            ShowButton();
        }

        

        private void btnLogOut_Click(object sender, EventArgs e)
        {      
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void btnToSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(employeeManager, currentEmp, departmentManager);
            schedule.Show();
        }

        private void btnToEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentEmp.GetBasicInfo());
        }

        private void btnToEmployeeManager_Click(object sender, EventArgs e)
        {
            EmployeeManagerForm EMF = new EmployeeManagerForm(memory, employeeManager, roleManager, productsAndRequestManager);
            EMF.Show();
        }

        private void btnStockRequest_Click(object sender, EventArgs e)
        {
            DepartmentAndRequest prm = new DepartmentAndRequest(employeeManager);
            prm.Show();
        }

        private void btnToStock_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.Show();
        }

        private void btnToRoleManager_Click(object sender, EventArgs e)
        {
            RoleManagerForm roleManagerForm = new RoleManagerForm(memory, employeeManager, roleManager);
            roleManagerForm.Show();
        }

        private void btSellProduct_Click(object sender, EventArgs e)
        {
            SellProductsForm sell = new SellProductsForm();
            sell.Show();
        }

        public void ShowButton()
        {
            if(currentEmp.GetAccessLevel() == 1)
            {
                btnRequest.Visible = false;
                btnStockRequest.Visible = false;
                btnToSchedule.Visible = false;
                btnToEmployeeManager.Visible = false;
                btnToRoleManager.Visible = false;
            }
            else if (currentEmp.GetAccessLevel() == 5)
            {
                btnStockRequest.Visible = false;
                btnToEmployeeManager.Visible = false;
                btnToRoleManager.Visible = false;
            }
            else if (currentEmp.GetAccessLevel() == 6)
            {
                btnToEmployeeManager.Visible = false;
                btnToRoleManager.Visible = false;
            }
            
        }

    }
}
