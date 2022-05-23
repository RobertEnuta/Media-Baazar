using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class Memory
    {
        private Employee emp;
        private ShiftManager shifts = new ShiftManager();
        private EmployeeManager employeeManager = new EmployeeManager();
        private RoleManager roleManager = new RoleManager();

        

        public void SetEmployee(Employee emp)
        {
            this.emp = emp;
        }

        public Employee GetEmployee()
        {
            return emp;
        }

        public EmployeeManager GetEmployeeManager()
        {
            return employeeManager;
        }

        public RoleManager GetRoleManager()
        {
            return roleManager;
        }

        public ShiftManager GetShiftManager()
        {
            return shifts;
        }
    }
}
