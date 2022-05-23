using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class UnavailableShift
    {
        private ShiftsEnum shiftType;
        private DayOfWeek dayOfWeek;
        public UnavailableShift(ShiftsEnum shiftType, DayOfWeek dayOfWeek)
        {
            this.shiftType = shiftType;
            this.dayOfWeek = dayOfWeek;
        }

        public ShiftsEnum GetShiftType()
        {
            return this.shiftType;
        }
        public DayOfWeek GetDayOfWeek()
        {
            return this.dayOfWeek;
        }
    }
}
