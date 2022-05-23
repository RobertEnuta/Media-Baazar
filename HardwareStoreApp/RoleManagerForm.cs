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
    public partial class RoleManagerForm : Form
    {
        Memory memory;
        EmployeeManager employeeManager;
        RoleManager roleManager;

        public RoleManagerForm(Memory memory, EmployeeManager employeeManager, RoleManager roleManager)
        {
            InitializeComponent();

            this.employeeManager = employeeManager;
            this.roleManager = roleManager;
            this.memory = memory;

            UpdateDisplay();
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (tbRoleNameUp.Text != "" && lbRoleDisplay.SelectedIndex != -1)
            {
                int i;
                if(dudAcessLevelUp.Text == "4")
                {
                    i = 10;
                }
                else if (dudAcessLevelUp.Text == "2")
                {
                    i = 5;
                }
                else if (dudAcessLevelUp.Text == "3")
                {
                    i = 6;
                }
                else 
                {
                    i = 1;
                }
                List<Role> R = roleManager.GetRoles();
                Role r = new Role(R[lbRoleDisplay.SelectedIndex].GetRoleID(), tbRoleNameUp.Text, i);
                roleManager.Update(r);
            }
            else
            {
                MessageBox.Show("Please fill in a name for the role");
            }
            UpdateDisplay();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if(tbRoleName.Text != "")
            {
                int i;
                if (dudAcessLevel.Text == "4")
                {
                    i = 10;
                }
                else if (dudAcessLevel.Text == "2")
                {
                    i = 5;
                }
                else if (dudAcessLevel.Text == "3")
                {
                    i = 6;
                }
                else
                {
                    i = 1;
                }
                Role R = new Role(0, tbRoleName.Text, i);
                roleManager.Add(R);
                
            }
            else
            {
                MessageBox.Show("Please fill in a name for the new role");
            }
            UpdateDisplay();
        }

        private void lbRoleDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbRoleDisplay.SelectedIndex != -1)
            {
                List<Role> R = roleManager.GetRoles();
                tbRoleNameUp.Text = R[lbRoleDisplay.SelectedIndex].GetRoleName();
                if(R[lbRoleDisplay.SelectedIndex].GetAccessLevel() == 1)
                {
                    dudAcessLevelUp.Text = "1";
                }
                else if (R[lbRoleDisplay.SelectedIndex].GetAccessLevel() == 5)
                {
                    dudAcessLevelUp.Text = "2";
                }
                else if (R[lbRoleDisplay.SelectedIndex].GetAccessLevel() == 6)
                {
                    dudAcessLevelUp.Text = "3";
                }
                else if (R[lbRoleDisplay.SelectedIndex].GetAccessLevel() == 10)
                {
                    dudAcessLevelUp.Text = "4";
                }
            }
            else
            {
                tbRoleNameUp.Text = "";
                dudAcessLevelUp.Text = "1";
            }
        }

        public void UpdateDisplay()
        {
            lbRoleDisplay.Items.Clear();

            List<Role> R = roleManager.GetRoles();

            foreach (Role r in R)
            {
                lbRoleDisplay.Items.Add(r.ToString());
            }
            lbRoleDisplay.SelectedIndex = -1;
        }
       
        private void btnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
