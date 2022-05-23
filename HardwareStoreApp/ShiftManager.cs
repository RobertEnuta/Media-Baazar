using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class ShiftManager
    {

        private List<Shift> shifts = new List<Shift>();

        public void AddShift(Shift shift)
        {
            shifts.Add(shift);
        }
        public List<Shift> GetAllShifts()
        {
            return shifts;
        }
        public Shift GetShiftByID(int id)
        {
            foreach (Shift shift in shifts)
            {
                if (shift.GetShiftID() == id)
                {
                    return shift;
                }
            }
            return null;
        }
        public void RemoveShift(Shift shift)
        {
            shifts.Remove(shift);
        }
        public void AddShifts(List<Shift> shiftz)
        {
            foreach (Shift shift in shiftz)
            {
                shifts.Add(shift);
            }
        }
        public void SetShifts(List<Shift> shiftz)
        {
            shifts = shiftz;
        }

    }
}
