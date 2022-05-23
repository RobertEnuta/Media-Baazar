using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public class Department
    {
        private string departmentName;
        private int departmentID;
        private int managerID;
        private string departmentDescription;
        private ShiftManager shiftManager;
        private static DBConnectionClass dbcon=new DBConnectionClass();

        public int GetDepartmentID()
        {
            return departmentID;
        }

        public Department(string departmentName, int managerID, string departmentDescription)
        {
            this.departmentName = departmentName;
            this.departmentDescription = departmentDescription;
            this.managerID = managerID;

            this.shiftManager = new ShiftManager();
        }
        public Department(string departmentName, int managerID, string departmentDescription, int departmentID)
        {
            this.departmentName = departmentName;
            this.departmentDescription = departmentDescription;
            this.managerID = managerID;
            this.departmentID = departmentID;

            this.shiftManager = new ShiftManager();
          
        }
        public void UpdateShifts() 
        {
            
            shiftManager.SetShifts(dbcon.ReadAllShiftsByDepartmentID(departmentID));
            
        }
        public void SetDepartmentID(int id)
        {
            this.departmentID = id;
        }
        public string DepartmentName { get { return departmentName; } }
        public int DepartmentID { get { return departmentID; } }
        public int ManagerID { get { return managerID; } }
        public string DepartmentDescription { get { return departmentDescription; } }

        public string GetDepartment()
        {
            return $"Department:{this.departmentID},{this.departmentName},{this.departmentDescription},{this.managerID}" ;                 
        }
        public ShiftManager GetShiftManager()
        {
            return shiftManager;
        }

        public string GetDepartmentName()
        {
            return departmentName;
        }


    }
}
