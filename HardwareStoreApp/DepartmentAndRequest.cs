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
    public partial class DepartmentAndRequest : Form
    {
        ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();
        EmployeeManager employeeManager = new EmployeeManager();

        public DepartmentAndRequest(EmployeeManager employeeManager)
        {
            InitializeComponent();
            this.employeeManager = employeeManager;
            updateDepartments();
            FillComboBoxNames();
        }
        public void FillComboBoxNames()
        {
            cbManagerID.Items.Clear();
            foreach (string Names in this.productsAndRequestManager.GetManagerNames())
            {
                cbManagerID.Items.Add(Names);
            }
        }
        private void updateDepartments()
        {
            lbDepartment.Items.Clear();

            foreach (Department department in (List<Department>)productsAndRequestManager.GetAllDepartments())
            {
                lbDepartment.Items.Add(department.GetDepartment());
            }
        }

        private void btnDisplayDepartments_Click(object sender, EventArgs e)
        {
            lbDepartment.Items.Clear();
            foreach (Department department in this.productsAndRequestManager.GetAllDepartments())
            {
                lbDepartment.Items.Add(department.GetDepartment());
            }
        }
        private void btnAddNewDepartment_Click_1(object sender, EventArgs e)
        {
            string departmentName = tbxNameOfDepartment.Text;
            string managerName = cbManagerID.Text;
            string departmentDescription = tbxDescriptionDepart.Text;

            try
            {
                Employee manager = employeeManager.GetManager(managerName);
                productsAndRequestManager.Add(new Department(departmentName, manager.GetEmployeeID(), departmentDescription));
                updateDepartments();
                FillComboBoxNames();
            }
            catch (EmptyStringExcption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error creating a new department has occurd! Try again.");
            }
            updateDepartments();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
