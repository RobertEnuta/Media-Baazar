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
    public partial class EmployeeEditor : Form
    {
        Memory memory;
        EmployeeManager employeeManager;
        RoleManager roleManager;
        ProductsAndRequestManager productsAndRequestManager;



        public EmployeeEditor(Memory memory, EmployeeManager employeeManager, RoleManager roleManager, ProductsAndRequestManager productsAndRequestManager)
        {
            InitializeComponent();
            cbEmpRole.Items.Clear();
            List<Role> R = roleManager.GetRoles();
            for (int counter = 0; counter < R.Count; counter++)
            {
                cbEmpRole.Items.Add(R[counter].GetRoleName());
            }
            this.employeeManager = employeeManager;
            this.roleManager = roleManager;
            this.productsAndRequestManager = productsAndRequestManager;

            UpdateEmpDisplay();
        }

        private void UpdateEmpDisplay()
        {
            lbEmployeeDisplay.Items.Clear();
            List<Employee> Es = employeeManager.GetEmployees();
            for (int counter = 0; counter < Es.Count; counter++)
            {
                lbEmployeeDisplay.Items.Add(Es[counter].GetBasicInfoStatus());
            }
            cbEmpDepartment.Items.Clear();
            List<Department> D = productsAndRequestManager.GetAllDepartments();
            foreach (Department d in D)
            {
                cbEmpDepartment.Items.Add(d.GetDepartmentName());
            }

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbEmployeeDisplay.SelectedIndex != -1)
            {             
                Employee E = employeeManager.GetEmployee(Convert.ToInt32(tbEmpID.Text));
                E.SetStatus(0);
                employeeManager.Update(E);

                UpdateEmpDisplay();
            }
            else
            {
                MessageBox.Show("Please select an employee to delete");
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (lbEmployeeDisplay.SelectedIndex != -1)
            {
                Employee E = new Employee(tbEmpFirstName.Text, tbEmpLastName.Text, tbEmpEmail.Text, tbEmpPhoneNr.Text, tbEmpAddress.Text, Convert.ToInt32(tbEmpBSN.Text), Convert.ToDecimal(tbEmpHourlyPay.Text), Convert.ToInt32(tbEmpID.Text), dtpDateOfBirth.Value, tbEmpPassword.Text, roleManager.FindRole(cbEmpRole.Text), Convert.ToDouble(rtbContract.Text), 1, productsAndRequestManager.FindDepartment(cbEmpDepartment.Text).GetDepartmentID());
                
                
                employeeManager.Update(E);

                UpdateEmpDisplay();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit");
            }
        }

        private void lbEmployeeDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployeeDisplay.SelectedIndex != -1)
            {
                List<Employee> Es = employeeManager.GetEmployees();
                tbEmpFirstName.Text = Es[lbEmployeeDisplay.SelectedIndex].GetFirstName();
                tbEmpLastName.Text = Es[lbEmployeeDisplay.SelectedIndex].GetSurname();
                tbEmpID.Text = Convert.ToString(Es[lbEmployeeDisplay.SelectedIndex].GetEmployeeID());
                tbEmpEmail.Text = Es[lbEmployeeDisplay.SelectedIndex].GetEmailAddress();
                tbEmpAddress.Text = Es[lbEmployeeDisplay.SelectedIndex].GetAddress();
                tbEmpBSN.Text = Convert.ToString(Es[lbEmployeeDisplay.SelectedIndex].GetBSN());
                tbEmpPassword.Text = Es[lbEmployeeDisplay.SelectedIndex].GetPassword();
                tbEmpPhoneNr.Text = Es[lbEmployeeDisplay.SelectedIndex].GetPhoneNumber();
                tbEmpHourlyPay.Text = Convert.ToString(Es[lbEmployeeDisplay.SelectedIndex].GetHourlyWage());
                cbEmpRole.Text = Es[lbEmployeeDisplay.SelectedIndex].GetEmpRoleName();
                dtpDateOfBirth.Value = Es[lbEmployeeDisplay.SelectedIndex].GetDateOfBirth();
                rtbContract.Text = Convert.ToString(Es[lbEmployeeDisplay.SelectedIndex].GetContract());
                cbEmpDepartment.Text = productsAndRequestManager.FindDepartmentByID(Es[lbEmployeeDisplay.SelectedIndex].GetDepartmentID()).GetDepartmentName();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            EmployeeManagerForm emf = new EmployeeManagerForm(memory, employeeManager, roleManager, productsAndRequestManager);
            emf.Show();
            this.Close();

        }
    }
}
