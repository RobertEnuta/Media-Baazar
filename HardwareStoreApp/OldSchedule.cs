using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{

    public partial class OldSchedule : Form
    {
        DateTime today = DateTime.Today;
        DateTime monday;
        DateTime tuesday;
        DateTime wednesday;
        DateTime thursday;
        DateTime friday;
        DateTime saturday;
        DateTime sunday;

        int weekCounter;

        Memory memory;
        EmployeeManager employeeManager;
        Employee currentEmp;
        private List<Employee> employeelist = new List<Employee>();
        private List<Department> department = new List<Department>();
        public DBConnectionClass DBConnectionClass = new DBConnectionClass();

        public OldSchedule(Memory memory, EmployeeManager employeeManager, Employee employee)
        {
            InitializeComponent();
            this.currentEmp = employee;
            this.memory = memory;
            //employeeManager = memory.GetEmployeeManager();

            this.employeeManager = employeeManager;
            employeelist = employeeManager.GetEmployees();
            DBConnectionClass.ReadAllFromShift(employeeManager);


            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                monday = today;
                tuesday = today.AddDays(1);
                wednesday = today.AddDays(2);
                thursday = today.AddDays(3);
                friday = today.AddDays(4);
                saturday = today.AddDays(5);
                sunday = today.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                monday = today.AddDays(-1);
                tuesday = today;
                wednesday = today.AddDays(1);
                thursday = today.AddDays(2);
                friday = today.AddDays(3);
                saturday = today.AddDays(4);
                sunday = today.AddDays(5);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                monday = today.AddDays(-2);
                tuesday = today.AddDays(-1);
                wednesday = today;
                thursday = today.AddDays(1);
                friday = today.AddDays(2);
                saturday = today.AddDays(3);
                sunday = today.AddDays(4);

            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                monday = today.AddDays(-3);
                tuesday = today.AddDays(-2);
                wednesday = today.AddDays(-1);
                thursday = today;
                friday = today.AddDays(1);
                saturday = today.AddDays(2);
                sunday = today.AddDays(3);

            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                monday = today.AddDays(-4);
                tuesday = today.AddDays(-3);
                wednesday = today.AddDays(-2);
                thursday = today.AddDays(-1);
                friday = today;
                saturday = today.AddDays(1);
                sunday = today.AddDays(2);

            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                monday = today.AddDays(-5);
                tuesday = today.AddDays(-4);
                wednesday = today.AddDays(-3);
                thursday = today.AddDays(-2);
                friday = today.AddDays(-1);
                saturday = today;
                sunday = today.AddDays(1);
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = today.AddDays(-6);
                tuesday = today.AddDays(-5);
                wednesday = today.AddDays(-4);
                thursday = today.AddDays(-3);
                friday = today.AddDays(-2);
                saturday = today.AddDays(-1);
                sunday = today;
            }

            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");
            if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                lblYear.Text = today.AddYears(-1).ToString("yyyy");
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                lblYear.Text = today.AddYears(-1).ToString("yyyy");
            }


            txbMondayDate.Text = monday.Day.ToString();
            txbTuesdayDate.Text = tuesday.Day.ToString();
            txbWednesdayDate.Text = wednesday.Day.ToString();
            txbThursdayDate.Text = thursday.Day.ToString();
            txbFridayDate.Text = friday.Day.ToString();
            txbSaturdayDate.Text = saturday.Day.ToString();
            txbSundayDate.Text = sunday.Day.ToString();

            if (Convert.ToInt32(txbTuesdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + tuesday.ToString("MMMM");

                //previous attempt
                //DateTime nextmonth;
                //nextmonth = tuesday.AddMonths(1);
                //lblMonth2.Text = "/" + nextmonth.ToString("MMMM");
            }
            else if (Convert.ToInt32(txbWednesdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + wednesday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbThursdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + thursday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbFridayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + friday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbSaturdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "";

            }
            else if (Convert.ToInt32(txbSundayDate.Text) == 1)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday)
                {
                    lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                    lblMonth2.Text = "";
                }
                else
                {
                    lblMonth2.Text = "";
                }

            }
            else
            {
                lblMonth2.Text = "";
            }
            
            RefreshAllEmployeesList();
            UpdateLists();
        }

        public void loadDataFromDatabaseEmployee()
        {
            employeelist = new List<Employee>();

            foreach (Employee o in (List<Employee>)DBConnectionClass.ReadAllFromEmployee())
            {
                employeelist.Add((Employee)o);
            }
        }
        public void loadDataFromDatabaseDepartment()
        {
            department = new List<Department>();

            foreach (Department d in (List<Department>)DBConnectionClass.ReadAllFromDepartment())
            {
                department.Add((Department)d);
            }
        }
        public void RefreshAllEmployeesList()
        {
            //change later when departments are added
            lbAllEmployees.Items.Clear();
            foreach (Employee emp in employeelist)
            {
                if (emp.GetEmpDepartmentName() == currentEmp.GetEmpDepartmentName())
                {

                }
                lbAllEmployees.Items.Add(emp);
            }
        }


        //sends back to today
        private void btnToday_Click(object sender, EventArgs e)
        {
            today = DateTime.Today;
            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                monday = today;
                tuesday = today.AddDays(1);
                wednesday = today.AddDays(2);
                thursday = today.AddDays(3);
                friday = today.AddDays(4);
                saturday = today.AddDays(5);
                sunday = today.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                monday = today.AddDays(-1);
                tuesday = today;
                wednesday = today.AddDays(1);
                thursday = today.AddDays(2);
                friday = today.AddDays(3);
                saturday = today.AddDays(4);
                sunday = today.AddDays(5);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                monday = today.AddDays(-2);
                tuesday = today.AddDays(-1);
                wednesday = today;
                thursday = today.AddDays(1);
                friday = today.AddDays(2);
                saturday = today.AddDays(3);
                sunday = today.AddDays(4);

            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                monday = today.AddDays(-3);
                tuesday = today.AddDays(-2);
                wednesday = today.AddDays(-1);
                thursday = today;
                friday = today.AddDays(1);
                saturday = today.AddDays(2);
                sunday = today.AddDays(3);

            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                monday = today.AddDays(-4);
                tuesday = today.AddDays(-3);
                wednesday = today.AddDays(-2);
                thursday = today.AddDays(-1);
                friday = today;
                saturday = today.AddDays(1);
                sunday = today.AddDays(2);

            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                monday = today.AddDays(-5);
                tuesday = today.AddDays(-4);
                wednesday = today.AddDays(-3);
                thursday = today.AddDays(-2);
                friday = today.AddDays(-1);
                saturday = today;
                sunday = today.AddDays(1);
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = today.AddDays(-6);
                tuesday = today.AddDays(-5);
                wednesday = today.AddDays(-4);
                thursday = today.AddDays(-3);
                friday = today.AddDays(-2);
                saturday = today.AddDays(-1);
                sunday = today;
            }

            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");




            txbMondayDate.Text = monday.Day.ToString();
            txbTuesdayDate.Text = tuesday.Day.ToString();
            txbWednesdayDate.Text = wednesday.Day.ToString();
            txbThursdayDate.Text = thursday.Day.ToString();
            txbFridayDate.Text = friday.Day.ToString();
            txbSaturdayDate.Text = saturday.Day.ToString();
            txbSundayDate.Text = sunday.Day.ToString();

            if (Convert.ToInt32(txbTuesdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + tuesday.ToString("MMMM");

                //previous attempt
                //DateTime nextmonth;
                //nextmonth = tuesday.AddMonths(1);
                //lblMonth2.Text = "/" + nextmonth.ToString("MMMM");
            }
            else if (Convert.ToInt32(txbWednesdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + wednesday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbThursdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + thursday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbFridayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + friday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbSaturdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "";

            }
            else if (Convert.ToInt32(txbSundayDate.Text) == 1)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday)
                {
                    lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                    lblMonth2.Text = "";
                }
                else
                {
                    lblMonth2.Text = "";
                }

            }
            else
            {
                lblMonth2.Text = "";
            }
            ResetWeekCounter();
            UpdateLists();

        }

        //updater for the date
        public int UpdateWeekCounter(bool action)
        {
            if (action == true)
            {
                weekCounter += 7;
            }
            else
            {
                weekCounter -= 7;
            }

            return weekCounter;
        }
        public void ResetWeekCounter()
        {
            weekCounter = 0;
        }

        //Calls all other list updaters 
        private void UpdateLists()
        {
            try
            {
                UpdateMondays();

                UpdateTuesdays();

                UpdateWednesdays();

                UpdateThursdays();

                UpdateFridays();

            }
            catch (Exception)
            {
                MessageBox.Show("now");
            }

        }

        //Updaters for each day of the workweek
        private void UpdateFridays()
        {
            lbFridayMorning.Items.Clear();
            lbFridayNoon.Items.Clear();
            lbFridayEvening.Items.Clear();

            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(txbFridayDate.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                }
            }

            foreach (Employee em in employeelist)
            {
                foreach (Shift s in em.GetShifts())
                {
                    if (s.GetDate() == thisDate)
                    {
                        if (s.GetShiftType() == ShiftsEnum.MORNING)
                        {
                            lbFridayMorning.Items.Add(em);
                        }
                        else if (s.GetShiftType() == ShiftsEnum.AFTERNOON)
                        {
                            lbFridayNoon.Items.Add(em);
                        }
                        else
                        {
                            lbFridayEvening.Items.Add(em);
                        }
                    }
                }
            }

        }
        private void UpdateThursdays()
        {
            lbThursdayMorning.Items.Clear();
            lbThursdayNoon.Items.Clear();
            lbThursdayEvening.Items.Clear();

            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(txbThursdayDate.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                }
            }

            foreach (Employee em in employeelist)
            {
                foreach (Shift s in em.GetShifts())
                {
                    if (s.GetDate() == thisDate)
                    {
                        if (s.GetShiftType() == ShiftsEnum.MORNING)
                        {
                            lbThursdayMorning.Items.Add(em);
                        }
                        else if (s.GetShiftType() == ShiftsEnum.AFTERNOON)
                        {
                            lbThursdayNoon.Items.Add(em);
                        }
                        else
                        {
                            lbThursdayEvening.Items.Add(em);
                        }
                    }
                }
            }

        }
        private void UpdateWednesdays()
        {
            lbWednesdayMorning.Items.Clear();
            lbWednesdayNoon.Items.Clear();
            lbWednesdayEvening.Items.Clear();

            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(txbWednesdayDate.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                }
            }

            foreach (Employee em in employeelist)
            {
                foreach (Shift s in em.GetShifts())
                {
                    if (s.GetDate() == thisDate)
                    {
                        if (s.GetShiftType() == ShiftsEnum.MORNING)
                        {
                            lbWednesdayMorning.Items.Add(em);
                        }
                        else if (s.GetShiftType() == ShiftsEnum.AFTERNOON)
                        {
                            lbWednesdayNoon.Items.Add(em);
                        }
                        else
                        {
                            lbWednesdayEvening.Items.Add(em);
                        }
                    }
                }
            }
        }
        private void UpdateTuesdays()
        {
            lbTuesdayMorning.Items.Clear();
            lbTuesdayNoon.Items.Clear();
            lbTuesdayEvening.Items.Clear();
            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(txbTuesdayDate.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                }
            }

            foreach (Employee em in employeelist)
            {
                foreach (Shift s in em.GetShifts())
                {
                    if (s.GetDate() == thisDate)
                    {
                        if (s.GetShiftType() == ShiftsEnum.MORNING)
                        {
                            lbTuesdayMorning.Items.Add(em);
                        }
                        else if (s.GetShiftType() == ShiftsEnum.AFTERNOON)
                        {
                            lbTuesdayNoon.Items.Add(em);
                        }
                        else
                        {
                            lbTuesdayEvening.Items.Add(em);
                        }
                    }
                }
            }
        }
        private void UpdateMondays()
        {
            lbMondayMorning.Items.Clear();
            lbMondayNoon.Items.Clear();
            lbMondayEvening.Items.Clear();

            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(txbMondayDate.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                }
            }

            foreach (Employee em in employeelist)
            {
                foreach (Shift s in em.GetShifts())
                {
                    if (s.GetDate() == thisDate)
                    {
                        if (s.GetShiftType() == ShiftsEnum.MORNING)
                        {
                            lbMondayMorning.Items.Add(em);
                        }
                        else if (s.GetShiftType() == ShiftsEnum.AFTERNOON)
                        {
                            lbMondayNoon.Items.Add(em);
                        }
                        else
                        {
                            lbMondayEvening.Items.Add(em);
                        }
                    }
                }
            }
        }

        //unselecter for the checkboxes
        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            cbMondayMorning.Checked = false;
            cbTuesdayMorning.Checked = false;
            cbWednesdayMorning.Checked = false;
            cbThursdayMorning.Checked = false;
            cbFridayMorning.Checked = false;

            cbMondayNoon.Checked = false;
            cbTuesdayNoon.Checked = false;
            cbWednesdayNoon.Checked = false;
            cbThursdayNoon.Checked = false;
            cbFridayNoon.Checked = false;

            cbMondayEvening.Checked = false;
            cbTuesdayEvening.Checked = false;
            cbWednesdayEvening.Checked = false;
            cbThursdayEvening.Checked = false;
            cbFridayEvening.Checked = false;

            UpdateLists();
        }

        //add and remove 
        private void btnAddToCalendar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int counter = 0;
                Employee emp = lbAllEmployees.SelectedItem as Employee;
                DBConnectionClass dbclass = new DBConnectionClass();
                //mornings
                {
                    if (cbMondayMorning.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbMondayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.MORNING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(),thisDate,ShiftsEnum.MORNING);
                        counter++;
                    }
                    if (cbTuesdayMorning.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbTuesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.MORNING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.MORNING);
                        counter++;
                    }
                    if (cbWednesdayMorning.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbWednesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.MORNING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.MORNING);
                        counter++;
                    }
                    if (cbThursdayMorning.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbThursdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.MORNING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.MORNING);
                        counter++;
                    }
                    if (cbFridayMorning.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbFridayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.MORNING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.MORNING);
                        counter++;
                    }
                }
                //noons
                {
                    if (cbMondayNoon.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbMondayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.AFTERNOON, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                        counter++;
                    }
                    if (cbTuesdayNoon.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbTuesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.AFTERNOON, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                        counter++;
                    }
                    if (cbWednesdayNoon.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbWednesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.AFTERNOON, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                        counter++;
                    }
                    if (cbThursdayNoon.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbThursdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.AFTERNOON, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                        counter++;
                    }
                    if (cbFridayNoon.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbFridayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.AFTERNOON, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                        counter++;
                    }
                }
                //evenings
                {
                    if (cbMondayEvening.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbMondayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.EVENING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                        counter++;
                    }
                    if (cbTuesdayEvening.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbTuesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.EVENING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                        counter++;
                    }
                    if (cbWednesdayEvening.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbWednesdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.EVENING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                        counter++;
                    }
                    if (cbThursdayEvening.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbThursdayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.EVENING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                        counter++;
                    }
                    if (cbFridayEvening.Checked == true)
                    {
                        int currentYear = Convert.ToInt32(lblYear.Text);
                        int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                        int currentDate = Convert.ToInt32(txbFridayDate.Text);
                        DateTime thisDate = new DateTime(currentYear, currentMonth, currentDate);

                        if (lblMonth2.Text != "")
                        {
                            string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                            int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (currentDate < 15)
                            {
                                thisDate = new DateTime(currentYear, currentMonth2, currentDate);
                            }
                        }

                        emp.AddShift(new Shift(thisDate, ShiftsEnum.EVENING, "dep"));
                        dbclass.InsertShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                        counter++;
                    }
                }

                //checker if nothing was selected
                if (counter == 0)
                {
                    throw new InvalidSelectionException();
                }

                UpdateLists();
            }
            catch (InvalidSelectionException)
            {
                MessageBox.Show("Nothing was selected!");
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem!");
            }
        }


        public void RemoveFromShift(ListBox lb, TextBox date)
        {
            DBConnectionClass dbclass=new DBConnectionClass();
            DateTime thisDate;
            int currentYear = Convert.ToInt32(lblYear.Text);
            int currentMonth = DateTime.ParseExact(lblMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int currentDate = Convert.ToInt32(date.Text);
            thisDate = new DateTime(currentYear, currentMonth, currentDate,0,0,0);

            if (lblMonth2.Text != "")
            {
                string month = (lblMonth2.Text).Trim(new Char[] { ' ', '/' });
                int currentMonth2 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                if (currentDate < 15)
                {
                    thisDate = new DateTime(currentYear, currentMonth2, currentDate,0,0,0);
                }
            }

            Employee emp = lb.SelectedItem as Employee;
            List<Shift> shiftsOfEmp = emp.GetShifts();
            for (int i = shiftsOfEmp.Count - 1; i >= 0; i--)
            {
                if (shiftsOfEmp[i].GetDate() == thisDate)
                {
                    if (shiftsOfEmp[i].GetShiftType() == ShiftsEnum.MORNING)
                    {
                        emp.RemoveShift(new Shift(thisDate, ShiftsEnum.MORNING));
                        dbclass.RemoveShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.MORNING);
                    }
                    else if (shiftsOfEmp[i].GetShiftType() == ShiftsEnum.AFTERNOON)
                    {
                        emp.RemoveShift(new Shift(thisDate, ShiftsEnum.AFTERNOON));
                        dbclass.RemoveShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.AFTERNOON);
                    }
                    else
                    {
                        emp.RemoveShift(new Shift(thisDate, ShiftsEnum.EVENING));
                        dbclass.RemoveShift(emp.GetEmployeeID(), thisDate, ShiftsEnum.EVENING);
                    }
                }
            }
        }
        private void btnRemoveFromCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                //mornings
                if (lbMondayMorning.SelectedIndex != -1)
                {
                    RemoveFromShift(lbMondayMorning, txbMondayDate);
                }
                if (lbTuesdayMorning.SelectedIndex != -1)
                {
                    RemoveFromShift(lbTuesdayMorning, txbTuesdayDate);
                }
                if (lbWednesdayMorning.SelectedIndex != -1)
                {
                    RemoveFromShift(lbWednesdayMorning, txbWednesdayDate);
                }
                if (lbThursdayMorning.SelectedIndex != -1)
                {
                    RemoveFromShift(lbThursdayMorning, txbThursdayDate);
                }
                if (lbFridayMorning.SelectedIndex != -1)
                {
                    RemoveFromShift(lbFridayMorning, txbFridayDate);
                }

                //noons
                if (lbMondayNoon.SelectedIndex != -1)
                {
                    RemoveFromShift(lbMondayNoon, txbMondayDate);
                }
                if (lbTuesdayNoon.SelectedIndex != -1)
                {
                    RemoveFromShift(lbTuesdayNoon, txbTuesdayDate);
                }
                if (lbWednesdayNoon.SelectedIndex != -1)
                {
                    RemoveFromShift(lbWednesdayNoon, txbWednesdayDate);
                }
                if (lbThursdayNoon.SelectedIndex != -1)
                {
                    RemoveFromShift(lbThursdayNoon, txbThursdayDate);
                }
                if (lbFridayNoon.SelectedIndex != -1)
                {
                    RemoveFromShift(lbFridayNoon, txbFridayDate);
                }

                //evenings
                if (lbMondayEvening.SelectedIndex != -1)
                {
                    RemoveFromShift(lbMondayEvening, txbMondayDate);
                }
                if (lbTuesdayEvening.SelectedIndex != -1)
                {
                    RemoveFromShift(lbTuesdayEvening, txbTuesdayDate);
                }
                if (lbWednesdayEvening.SelectedIndex != -1)
                {
                    RemoveFromShift(lbWednesdayEvening, txbWednesdayDate);
                }
                if (lbThursdayEvening.SelectedIndex != -1)
                {
                    RemoveFromShift(lbThursdayEvening, txbThursdayDate);
                }
                if (lbFridayEvening.SelectedIndex != -1)
                {
                    RemoveFromShift(lbFridayEvening, txbFridayDate);
                }

                UpdateLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //next and previous week buttons

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            int newDays = UpdateWeekCounter(true);
            today = DateTime.Today;
            today = today.AddDays(newDays);


            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                monday = today;
                tuesday = today.AddDays(1);
                wednesday = today.AddDays(2);
                thursday = today.AddDays(3);
                friday = today.AddDays(4);
                saturday = today.AddDays(5);
                sunday = today.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                monday = today.AddDays(-1);
                tuesday = today;
                wednesday = today.AddDays(1);
                thursday = today.AddDays(2);
                friday = today.AddDays(3);
                saturday = today.AddDays(4);
                sunday = today.AddDays(5);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                monday = today.AddDays(-2);
                tuesday = today.AddDays(-1);
                wednesday = today;
                thursday = today.AddDays(1);
                friday = today.AddDays(2);
                saturday = today.AddDays(3);
                sunday = today.AddDays(4);

            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                monday = today.AddDays(-3);
                tuesday = today.AddDays(-2);
                wednesday = today.AddDays(-1);
                thursday = today;
                friday = today.AddDays(1);
                saturday = today.AddDays(2);
                sunday = today.AddDays(3);

            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                monday = today.AddDays(-4);
                tuesday = today.AddDays(-3);
                wednesday = today.AddDays(-2);
                thursday = today.AddDays(-1);
                friday = today;
                saturday = today.AddDays(1);
                sunday = today.AddDays(2);

            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                monday = today.AddDays(-5);
                tuesday = today.AddDays(-4);
                wednesday = today.AddDays(-3);
                thursday = today.AddDays(-2);
                friday = today.AddDays(-1);
                saturday = today;
                sunday = today.AddDays(1);
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = today.AddDays(-6);
                tuesday = today.AddDays(-5);
                wednesday = today.AddDays(-4);
                thursday = today.AddDays(-3);
                friday = today.AddDays(-2);
                saturday = today.AddDays(-1);
                sunday = today;
            }

            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");




            txbMondayDate.Text = monday.Day.ToString();
            txbTuesdayDate.Text = tuesday.Day.ToString();
            txbWednesdayDate.Text = wednesday.Day.ToString();
            txbThursdayDate.Text = thursday.Day.ToString();
            txbFridayDate.Text = friday.Day.ToString();
            txbSaturdayDate.Text = saturday.Day.ToString();
            txbSundayDate.Text = sunday.Day.ToString();

            if (Convert.ToInt32(txbTuesdayDate.Text) == 1)
            {
                lblMonth.Text = today.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + tuesday.ToString("MMMM");

                //previous attempt
                //DateTime nextmonth;
                //nextmonth = tuesday.AddMonths(1);
                //lblMonth2.Text = "/" + nextmonth.ToString("MMMM");
            }
            else if (Convert.ToInt32(txbWednesdayDate.Text) == 1)
            {
                lblMonth.Text = wednesday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + wednesday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbThursdayDate.Text) == 1)
            {
                lblMonth.Text = thursday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + thursday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbFridayDate.Text) == 1)
            {
                lblMonth.Text = friday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + friday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbSaturdayDate.Text) == 1)
            {
                lblMonth.Text = saturday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "";

            }
            else if (Convert.ToInt32(txbSundayDate.Text) == 1)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday)
                {
                    lblMonth.Text = sunday.AddMonths(-1).ToString("MMMM");
                    lblMonth2.Text = "";
                }
                else
                {
                    lblMonth2.Text = "";
                }

            }
            else
            {

                lblMonth2.Text = "";
            }

            UpdateLists();
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            int newDays = UpdateWeekCounter(false);
            today = DateTime.Today;
            today = today.AddDays(newDays);


            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                monday = today;
                tuesday = today.AddDays(1);
                wednesday = today.AddDays(2);
                thursday = today.AddDays(3);
                friday = today.AddDays(4);
                saturday = today.AddDays(5);
                sunday = today.AddDays(6);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                monday = today.AddDays(-1);
                tuesday = today;
                wednesday = today.AddDays(1);
                thursday = today.AddDays(2);
                friday = today.AddDays(3);
                saturday = today.AddDays(4);
                sunday = today.AddDays(5);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                monday = today.AddDays(-2);
                tuesday = today.AddDays(-1);
                wednesday = today;
                thursday = today.AddDays(1);
                friday = today.AddDays(2);
                saturday = today.AddDays(3);
                sunday = today.AddDays(4);

            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                monday = today.AddDays(-3);
                tuesday = today.AddDays(-2);
                wednesday = today.AddDays(-1);
                thursday = today;
                friday = today.AddDays(1);
                saturday = today.AddDays(2);
                sunday = today.AddDays(3);

            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                monday = today.AddDays(-4);
                tuesday = today.AddDays(-3);
                wednesday = today.AddDays(-2);
                thursday = today.AddDays(-1);
                friday = today;
                saturday = today.AddDays(1);
                sunday = today.AddDays(2);

            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                monday = today.AddDays(-5);
                tuesday = today.AddDays(-4);
                wednesday = today.AddDays(-3);
                thursday = today.AddDays(-2);
                friday = today.AddDays(-1);
                saturday = today;
                sunday = today.AddDays(1);
            }
            else if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = today.AddDays(-6);
                tuesday = today.AddDays(-5);
                wednesday = today.AddDays(-4);
                thursday = today.AddDays(-3);
                friday = today.AddDays(-2);
                saturday = today.AddDays(-1);
                sunday = today;
            }

            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");




            txbMondayDate.Text = monday.Day.ToString();
            txbTuesdayDate.Text = tuesday.Day.ToString();
            txbWednesdayDate.Text = wednesday.Day.ToString();
            txbThursdayDate.Text = thursday.Day.ToString();
            txbFridayDate.Text = friday.Day.ToString();
            txbSaturdayDate.Text = saturday.Day.ToString();
            txbSundayDate.Text = sunday.Day.ToString();

            if (Convert.ToInt32(txbTuesdayDate.Text) == 1)
            {
                lblMonth.Text = tuesday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + tuesday.ToString("MMMM");

                //previous attempt
                //DateTime nextmonth;
                //nextmonth = tuesday.AddMonths(1);
                //lblMonth2.Text = "/" + nextmonth.ToString("MMMM");
            }
            else if (Convert.ToInt32(txbWednesdayDate.Text) == 1)
            {
                lblMonth.Text = wednesday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + wednesday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbThursdayDate.Text) == 1)
            {
                lblMonth.Text = thursday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + thursday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbFridayDate.Text) == 1)
            {
                lblMonth.Text = friday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "/" + friday.ToString("MMMM");

            }
            else if (Convert.ToInt32(txbSaturdayDate.Text) == 1)
            {
                lblMonth.Text = saturday.AddMonths(-1).ToString("MMMM");
                lblMonth2.Text = "";

            }
            else if (Convert.ToInt32(txbSundayDate.Text) == 1)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday)
                {
                    lblMonth.Text = sunday.AddMonths(-1).ToString("MMMM");
                    lblMonth2.Text = "";
                }
                else
                {
                    lblMonth2.Text = "";
                }

            }
            else
            {
                lblMonth2.Text = "";
            }

            UpdateLists();
        }


    }
}
