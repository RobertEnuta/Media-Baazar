using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public class EmployeeManager
    { 
    private List<Employee> employeeList = new List<Employee>();
    private List<Department> department = new List<Department>();
    public DBConnectionClass DBConnectionClass;

    public EmployeeManager()
    {
        DBConnectionClass = new DBConnectionClass();
        loadDataFromDatabaseEmployee();
    }


    public void Add(Department department)
    {
        int n = 0;
        try
        {
            n = DBConnectionClass.InsertDepartment((Department)department);
            if (n == 0)
            {
                MessageBox.Show("Failed to add department");
            }
            else
            {
                loadDataFromDatabaseDepartment();
            }

        }
        catch (AddingToDBFailedException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public Employee GetManager(string managerName)
    {
        Employee E = null;
        foreach(Employee e in employeeList)
        {
             if(managerName == e.GetFirstName() + " " + e.GetSurname())
             {
                E = e;
             }
        }
        return E;
    }

    public void Add(Employee employee)
    {
        try
        {
            DBConnectionClass.InsertEmployee((Employee)employee);
            loadDataFromDatabaseEmployee();
        }
        catch (AddingToDBFailedException ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    public void Update(Employee employee)
        {
            try
            {
                DBConnectionClass.UpdateEmployee((Employee)employee);
                loadDataFromDatabaseEmployee();
            }
            catch (AddingToDBFailedException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    public void loadDataFromDatabaseEmployee()
    {
        employeeList = new List<Employee>();

        foreach (Employee o in (List<Employee>)DBConnectionClass.ReadAllFromEmployee())
        {
            employeeList.Add((Employee)o);
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


    
    public Employee GetEmployee(int EmployeeID)
    {
        for (int counter = 0; counter < employeeList.Count; counter++)
        {
            if (employeeList[counter].GetEmployeeID() == EmployeeID)
            {
                return employeeList[counter];
            }

        }
        return null;
    }
    public bool RemoveEmployee(int employeeId)
    {
        for (int counter = 0; counter < employeeList.Count; counter++)
        {
            if (employeeList[counter].GetEmployeeID() == employeeId)
            {
                employeeList.RemoveAt(counter);
                return true;
            }

        }
        return false;
    }

    public List<Employee> GetEmployees()
    {
        return employeeList;
    }
    
   

       

    }
}

