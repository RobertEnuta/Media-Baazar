using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class DepartmentManager
    {
        private List<Department> departmentList = new List<Department>();

        public List<Department> GetDepartments()
        {
            return departmentList;
        }

        public Department GetDepartment(string DepartmentName)
        {
            for (int counter = 0; counter < departmentList.Count; counter++)
            {
                if (departmentList[counter].GetDepartmentName() == DepartmentName)
                {
                    return departmentList[counter];
                }

            }
            return null;
        }

        public void AddDepartment(Department emp)
        {
            departmentList.Add(emp);

        }

        public bool RemoveDepartment(string DepartmentName)
        {
            for (int counter = 0; counter < departmentList.Count; counter++)
            {
                if (departmentList[counter].GetDepartmentName() == DepartmentName)
                {
                    departmentList.RemoveAt(counter);
                    return true;
                }

            }
            return false;
        }

        public Department FindDepartment(string DepartmentName)
        {
            for (int counter = 0; counter < departmentList.Count; counter++)
            {
                if (departmentList[counter].GetDepartmentName() == DepartmentName)
                {
                    return departmentList[counter];
                }

            }
            return null;
        }

        public void SetDepartments(List<Department> DBInput)
        {
            departmentList = DBInput;
        }
        public void AddDepartments(List<Department> departments)
        {
            foreach (Department department in departments)
            {
                departmentList.Add(department);
            }
        }

    }
}
