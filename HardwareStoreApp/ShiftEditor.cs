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
    public partial class ShiftEditor : Form
    {
       
        private DateTime today = DateTime.Now;
        private Shift currentShift;
        private ShiftManager shiftManager;
        private Department dep;
        private EmployeeManager employeeManager;
        private DBConnectionClass dbcon;
        private Employee passableEmployee;
        private DepartmentManager passableDepartmentManager;
        public ShiftEditor(ShiftManager shiftManager, EmployeeManager employeeManager, Department dep, Shift currentShift,Employee passableEmployee,DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.currentShift = currentShift;
            this.shiftManager = shiftManager;
            this.currentShift = currentShift;
            this.employeeManager = employeeManager;
            this.passableEmployee = passableEmployee;
            this.dep = dep;
            this.passableDepartmentManager = departmentManager;
            dbcon = new DBConnectionClass();
            lblShiftType.Text = currentShift.GetShiftType().ToString();
            lblShiftType.Text = this.currentShift.GetShiftType().ToString();
            lblInfo.Text = this.currentShift.GetDate().ToString();
            lblDate.Text= this.currentShift.GetDate().ToString("MMMM dd, yyyy");

            UpdateAssignedEmployees();
            UpdateAssignableEmployees();
            UpdateButtons();
        }
        //updates the two listboxes
        public void UpdateAssignedEmployees()
        {
            lbAssignedToShift.Items.Clear();
            ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), lblShiftType.Text);
            DateTime date = Convert.ToDateTime(lblInfo.Text);

            foreach (Shift s in dep.GetShiftManager().GetAllShifts())
            {
                if (s.GetDate() == date && s.GetShiftType() == shiftenum)
                {
                    Employee emp = s.GetEmployee();
                    emp.UpdateUnavailableShifts();
                    string availability = "Available";
                    foreach (UnavailableShift unavailableShift in emp.GetUnavailableShifts())
                    {
                        if (unavailableShift.GetDayOfWeek() == date.DayOfWeek && shiftenum == unavailableShift.GetShiftType())
                        {
                            availability = "Unavailable";
                        }
                    }

                    int numberOfPossibleShifts = GetNumberOfPossibleShifts(emp);
                    int numberOfActualShifts = GetNumberOfActualShifts(emp);
                    lbAssignedToShift.Items.Add(emp.GetFirstName() + " " + emp.GetSurname() + " - " + numberOfActualShifts + "/" + numberOfPossibleShifts + " " + availability);
                }
            }
        }
        public void UpdateAssignableEmployees()
        {
            lbAvailableToAssign.Items.Clear();
            foreach (Employee emp in employeeManager.GetEmployees())
            {
                //checks how many shifts the person already has for that month
                int numberOfActualShifts = GetNumberOfActualShifts(emp);
                //checks the contract of the person and how many shifts he can work max for the month
                int numberOfPossibleShifts = GetNumberOfPossibleShifts(emp);
                string availability = "Available";

                bool shiftMoreThanTwoCheck = false;
                emp.UpdateUnavailableShifts();
                if (dep.DepartmentID == emp.GetDepartmentID())//checks if the employee is in the same department
                {

                    foreach (Shift s in dep.GetShiftManager().GetAllShifts()) //checks if the employee is already in this shift- might be wrong
                    {
                        ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), lblShiftType.Text);
                        DateTime date = Convert.ToDateTime(lblInfo.Text);
                        //could also be done with the currentshift getter methods, note to look into this later<<<<<<<

                        if (CheckShiftsForTheDay(emp))
                        {
                            if (!CheckIfAlreadyScheduledTwice(emp, date, shiftenum))
                            {
                                shiftMoreThanTwoCheck = true;
                                //checks if the person has marked this date as available or not

                                foreach (UnavailableShift unavailableShift in emp.GetUnavailableShifts())
                                {
                                    if (unavailableShift.GetDayOfWeek() == date.DayOfWeek && shiftenum == unavailableShift.GetShiftType())
                                    {
                                        availability = "Unavailable";
                                    }
                                }
                            }
                        }
                    }
                }
                if (numberOfActualShifts < numberOfPossibleShifts && shiftMoreThanTwoCheck == true && emp.GetStatus()==1)
                {
                    string addition = emp.GetFirstName() + " " + emp.GetSurname() + " - " + numberOfActualShifts + "/" + numberOfPossibleShifts + " " + availability;
                    if (!lbAssignedToShift.Items.Contains(addition))
                    {
                        lbAvailableToAssign.Items.Add(addition);
                    }
                }
            }
        }
        private bool CheckIfAlreadyScheduledTwice(Employee emp, DateTime day, ShiftsEnum shiftsEnum)
        {

            int counter = 0;
            foreach (Shift shift in shiftManager.GetAllShifts())
            {
                if (shift.GetDate() == day && shift.GetEmployee().GetEmployeeID() == emp.GetEmployeeID())
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                return false;
            }
            return true;
        }
        private bool CheckShiftsForTheDay(Employee emp)
        {
            foreach (Shift s in shiftManager.GetAllShifts())
            {
                if (currentShift.GetDate() == s.GetDate() && emp == s.GetEmployee())
                {
                    return false;
                }
            }
            return true;
        }
        public int GetNumberOfPossibleShifts(Employee emp)
        {
            int numberOfPossibleShifts = Convert.ToInt32(emp.GetContract() * 10 * 4);
            return numberOfPossibleShifts;
        }
        public int GetNumberOfActualShifts(Employee emp)
        {
            int numberOfActualShifts = 0;
            foreach (Shift shift in shiftManager.GetAllShifts())
            {
                if (shift.GetEmployee().GetEmployeeID() == emp.GetEmployeeID() && shift.GetDate().Month == currentShift.GetDate().Month && shift.GetDate().Year == currentShift.GetDate().Year)
                {
                    numberOfActualShifts+=4;
                }
            }
            return numberOfActualShifts;
        }
        public Employee GetEmployeeFromString(string fullstring)
        {
            string[] substring = fullstring.Split(' '); //this could be an issue if a person was named.. say Frank De Lepper, because it's going to start looking for Frank De instead of Frank Lepper, I'm sorry, Frank
            string firstname = substring[0];
            string lastname = substring[1];

            ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), lblShiftType.Text);
            DateTime date = Convert.ToDateTime(lblInfo.Text);

            foreach (Employee emp in employeeManager.GetEmployees())
            {
                if (emp.GetFirstName() == firstname && emp.GetSurname() == lastname)
                {

                    return emp;
                }
            }
            return null;
        }


        //button to assign employees to the shift
        private void btnEditEveningShifts_Click(object sender, EventArgs e)
        {
            try
            {
                string fullstring = lbAvailableToAssign.SelectedItem.ToString();
                Employee employee = GetEmployeeFromString(fullstring);
                ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), lblShiftType.Text);
                DateTime date = Convert.ToDateTime(lblInfo.Text);
                Shift shift = new Shift(date, shiftenum, employee);
                dbcon.InsertShift(shift, dep);

                dep.UpdateShifts();
                UpdateAssignedEmployees();
                UpdateAssignableEmployees();
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't select anything!");
            }
            
        }

        //button to remove employees from shift
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fullstring = lbAssignedToShift.SelectedItem.ToString();
                Employee employee = GetEmployeeFromString(fullstring);
                ShiftsEnum shiftenum = (ShiftsEnum)Enum.Parse(typeof(ShiftsEnum), lblShiftType.Text);
                DateTime date = Convert.ToDateTime(lblInfo.Text);
                Shift shift = new Shift(date, shiftenum, employee);
                dbcon.RemoveShift(shift, dep);

                dep.UpdateShifts();
                UpdateAssignedEmployees();
                UpdateAssignableEmployees();
            }
            catch (Exception)
            { 
                MessageBox.Show("You didn't select anything!");
            }
            
        }

        private void UpdateButtons()
        {
            DateTime todayPlus = today.AddDays(-1);
            if (currentShift.GetDate() < todayPlus)
            {
                btnEditEveningShifts.Hide();
                btnRemoveEmployee.Hide();
            }
            else
            {
                btnEditEveningShifts.Show();
                btnRemoveEmployee.Show();
            }

        }

        private void ShiftEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Schedule schedule = new Schedule(employeeManager,passableEmployee,passableDepartmentManager);
            schedule.Show();
        }
    }
}
