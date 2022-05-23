using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class Shift
    {
        //make departement a Department object

        private DateTime date = new DateTime();
        private ShiftsEnum shiftType;
        private int shiftID;
        private Employee employee;

        public Shift(DateTime day, ShiftsEnum shift, Employee employee)
        {
            this.date = day;

            this.shiftType = shift;
            this.employee = employee;
        }
        public Shift(DateTime day, ShiftsEnum shift)
        {
            this.date = day;

            this.shiftType = shift;
        }

        public DateTime GetDate()
        {
            return date;
        }
        public ShiftsEnum GetShiftType()
        {
            return shiftType;
        }
        public Employee GetEmployee()
        {
            return employee;
        }
        public void SetShiftID(int shiftID) 
        {
            this.shiftID = shiftID;
        }
        public int GetShiftID()
        {
            return shiftID;
        }
    }
}
