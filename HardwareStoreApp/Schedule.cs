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
    public partial class Schedule : Form
    {
        private DateTime today = DateTime.Now;
        private DepartmentManager departmentManager;
        private EmployeeManager employeeManager;
        private Employee currentEmp;
        private Department department;
        private List<Shift> shifts = new List<Shift>(); //shifts of the entire department
        private ShiftManager shiftManager;
        private List<Shift> morningShifts = new List<Shift>();
        private List<Shift> afternoonShifts = new List<Shift>();
        private List<Shift> eveningShifts = new List<Shift>();
        //vzima se ot departmenta vsichki shiftove i po tip i data se update-vat listovete
        public Schedule(EmployeeManager employeeManager, Employee employee, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.currentEmp = employee;
            this.employeeManager = employeeManager;
            this.departmentManager = departmentManager;
            foreach (Department dep in departmentManager.GetDepartments())
            {

                if (dep.DepartmentID == employee.GetDepartmentID())
                {

                    department = dep;
                    department.UpdateShifts();
                }
            }
            shiftManager = department.GetShiftManager();
            foreach (Shift s in shiftManager.GetAllShifts())
            {
                shifts.Add(s);
            }
            UpdateListbox(lbMorningShifts, ShiftsEnum.MORNING);
            UpdateListbox(lbAfternoonShifts, ShiftsEnum.AFTERNOON);
            UpdateListbox(lbEveningShifts, ShiftsEnum.EVENING);
            UpdateButtons();

        }

        private void UpdateButtons()
        {
            DateTime todayPlus = today.AddDays(-1);
            if (calendar.SelectedDate < todayPlus)
            {
                btnEditAfternoonShifts.Text = "See Shift";
                btnEditEveningShifts.Text   = "See Shift";
                btnEditMorningShifts.Text   = "See Shift";
            }
            else
            {
                btnEditAfternoonShifts.Text = "Edit Shift";
                btnEditEveningShifts.Text   = "Edit Shift";
                btnEditMorningShifts.Text   = "Edit Shift";
            }
            
        }

        //update on each date change
        private void calendar_Click(object sender, EventArgs e)
        {
            UpdateListbox(lbMorningShifts, ShiftsEnum.MORNING);
            UpdateListbox(lbAfternoonShifts, ShiftsEnum.AFTERNOON);
            UpdateListbox(lbEveningShifts, ShiftsEnum.EVENING);
            department.UpdateShifts();
            UpdateButtons();
        }
        //updates for each shift typea
        private void UpdateListbox(ListBox lb, ShiftsEnum senum)
        {
            Employee emp;
            string addition = "";
            string availability = "Available";
            lb.Items.Clear();
            foreach (Shift s in shifts)
            {
                if (s.GetShiftType() == senum && s.GetDate() == calendar.SelectedDate)
                {
                    emp = s.GetEmployee();
                    foreach (UnavailableShift unavailableShift in emp.GetUnavailableShifts())
                    {
                        if (unavailableShift.GetDayOfWeek() == s.GetDate().DayOfWeek && s.GetShiftType() == unavailableShift.GetShiftType())
                        {
                            availability = "Unavailable";
                        }
                    }

                    addition = emp.GetFirstName() + " " + emp.GetSurname() + " - " + GetNumberOfActualShifts(emp, s) + "/" + GetNumberOfPossibleShifts(emp) + " " + availability;
                    if (addition != "")
                    {
                        lb.Items.Add(addition);
                    }
                }
            }
        }
        public int GetNumberOfPossibleShifts(Employee emp)
        {
            int numberOfPossibleShifts = Convert.ToInt32(emp.GetContract() * 10 * 4);
            return numberOfPossibleShifts;
        }
        public int GetNumberOfActualShifts(Employee emp, Shift currentShift)
        {
            int numberOfActualShifts = 0;
            foreach (Shift shift in shiftManager.GetAllShifts())
            {
                if (shift.GetEmployee().GetEmployeeID() == emp.GetEmployeeID() && shift.GetDate().Month == currentShift.GetDate().Month && shift.GetDate().Year == currentShift.GetDate().Year)
                {
                    numberOfActualShifts += 4;
                }
            }
            return numberOfActualShifts;
        }


        //buttons to edit for each of the shifttypes
        private void btnEditMorning_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(Convert.ToString(Convert.ToDateTime(calendar.SelectedDate)));
            Shift currentShift = new Shift(Convert.ToDateTime(calendar.SelectedDate), ShiftsEnum.MORNING);
            ShiftEditor sEditor = new ShiftEditor(shiftManager, employeeManager, department, currentShift, currentEmp, departmentManager);
            sEditor.Show();
            this.Close();
        }
        private void btnEditAfternoonShifts_Click(object sender, EventArgs e)
        {
            Shift currentShift = new Shift(Convert.ToDateTime(calendar.SelectedDate), ShiftsEnum.AFTERNOON);
            ShiftEditor sEditor = new ShiftEditor(shiftManager, employeeManager, department, currentShift, currentEmp, departmentManager);
            sEditor.Show();
            this.Close();
        }
        private void btnEditEveningShifts_Click(object sender, EventArgs e)
        {
            Shift currentShift = new Shift(Convert.ToDateTime(calendar.SelectedDate), ShiftsEnum.EVENING);
            ShiftEditor sEditor = new ShiftEditor(shiftManager, employeeManager, department, currentShift,currentEmp,departmentManager);
            sEditor.Show();
            this.Close();
        }

    }
}
