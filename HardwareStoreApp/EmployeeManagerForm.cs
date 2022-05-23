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
    public partial class EmployeeManagerForm : Form
    {
        Memory memory;
        EmployeeManager employeeManager;
        RoleManager roleManager;
        ProductsAndRequestManager productsAndRequestManager;
        

        public EmployeeManagerForm(Memory memory, EmployeeManager employeeManager, RoleManager roleManager, ProductsAndRequestManager productsAndRequestManager)
        {
            InitializeComponent();  
            this.employeeManager = employeeManager;
            this.roleManager = roleManager;
            this.productsAndRequestManager = productsAndRequestManager;

            UpdateEmpDisplay();
           
            
        }
        private void UpdateRoles()
        {

            cbEmpRole.Items.Clear();
            List<Role> R = roleManager.GetRoles();
            for (int counter = 0; counter < R.Count; counter++)
            {
                cbEmpRole.Items.Add(R[counter].GetRoleName());
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (tbEmpAddress.Text != "" && tbEmpBSN.Text != "" && tbEmpEmail.Text != "" && tbEmpFirstName.Text != "" && tbEmpHourlyPay.Text != "" && tbEmpLastName.Text != "" && tbEmpPassword.Text != "" && tbEmpPhoneNr.Text != "" && cbEmpRole.Text != "")
            {
                Employee E = new Employee(tbEmpFirstName.Text, tbEmpLastName.Text, tbEmpEmail.Text, tbEmpPhoneNr.Text, tbEmpAddress.Text, Convert.ToInt32(tbEmpBSN.Text), Convert.ToDecimal(tbEmpHourlyPay.Text), 0, dtpDateOfBirth.Value, tbEmpPassword.Text, roleManager.FindRole(cbEmpRole.Text), Convert.ToDouble(rtbContract.Text), 1, productsAndRequestManager.FindDepartment(cbEmpDepartment1.Text).GetDepartmentID());
                employeeManager.Add(E);
                UpdateEmpDisplay();
                
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> Es = employeeManager.GetEmployees();
            Es[lbEmployeeDisplay.SelectedIndex].SetEmployeeID(Convert.ToInt32(tbEmpID.Text));
            Es[lbEmployeeDisplay.SelectedIndex].SetBSN(Convert.ToInt32(tbEmpBSN.Text));
            Es[lbEmployeeDisplay.SelectedIndex].SetHourlyWage(Convert.ToInt32(tbEmpHourlyPay.Text));
            Es[lbEmployeeDisplay.SelectedIndex].SetAddress(tbEmpAddress.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetEmail(tbEmpEmail.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetFirstName(tbEmpFirstName.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetLastName(tbEmpLastName.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetPassword(tbEmpPassword.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetPhoneNr(tbEmpPhoneNr.Text);
            Es[lbEmployeeDisplay.SelectedIndex].SetRole(roleManager.FindRole(cbEmpRole.Text));
            Es[lbEmployeeDisplay.SelectedIndex].SetDateOfBirth(dtpDateOfBirth.Value);

            UpdateEmpDisplay();
            MessageBox.Show("Succeses!", "Action successful", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
        }


        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbEmployeeDisplay.SelectedIndex != -1)
            {
                tbEmpFirstName.Text = "";
                tbEmpLastName.Text = "";
                tbEmpID.Text = "";
                tbEmpEmail.Text = "";
                tbEmpAddress.Text = "";
                tbEmpPassword.Text = "";
                tbEmpPhoneNr.Text = "";
                tbEmpHourlyPay.Text = "";
                tbEmpBSN.Text = "";
                cbEmpRole.Text = "";

                List<Employee> Es = employeeManager.GetEmployees();
                employeeManager.RemoveEmployee(Es[lbEmployeeDisplay.SelectedIndex].GetEmployeeID());
                UpdateEmpDisplay();
                MessageBox.Show("Succeses!", "Action successful", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
        }
        private void btnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateEmpDisplay()
        {
            employeeManager.loadDataFromDatabaseEmployee();
            roleManager.loadDataFromDatabaseRole();

            lbEmployeeDisplay.Items.Clear();
            List<Employee> Es = employeeManager.GetEmployees();
            for (int counter = 0; counter < Es.Count; counter++)
            {
                if(Es[counter].GetStatus() == 1)
                {
                    lbEmployeeDisplay.Items.Add(Es[counter].GetBasicInfo());
                }
                
            }
            cbEmpDepartment1.Items.Clear();

            List<Department> D = productsAndRequestManager.GetAllDepartments();
            foreach (Department d in D)
            {
                cbEmpDepartment1.Items.Add(d.GetDepartmentName());
            }

            UpdateRoles();
        }

        private void ToEmployeeEditorbtn_Click(object sender, EventArgs e)
        {
            EmployeeEditor ee = new EmployeeEditor(memory, employeeManager, roleManager, productsAndRequestManager);
            ee.Show();
            this.Close();
        }

        
    }
}
