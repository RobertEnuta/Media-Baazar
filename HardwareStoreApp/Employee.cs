  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class Employee
    {
        private static DBConnectionClass dbcon = new DBConnectionClass();
        private List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
        private int employeeID;
        private string firstName;
        private string surname;
        private string email;
        private string phoneNumber;
        private string address;
        private double contract;
        private int BSN;
        private decimal hourlyWage;
        private DateTime dateOfBirth;
        private Role role;
        private string password;
        private int status;
        private int departmentID;


        public Role Role
        {
            get
            {
                return this.role;
            }
            set
            {
                this.role = value;
            }
        }

        public Employee(string firstName, string surname, string email, string phoneNumber, string address, int BSN, decimal hourlyWage, DateTime dateOfBirth, string password, Role role, double contract)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.BSN = BSN;
            this.hourlyWage = hourlyWage;
            this.dateOfBirth = dateOfBirth;
            this.password = password;
            this.contract = contract;
            this.role = role;
            status = 1;
            departmentID = 0;


        }

        public Employee(string firstName, string surname, string email, string phoneNumber, string address, int BSN, decimal hourlyWage, int employeeID, DateTime dateOfBirth, string password, Role role, double contract)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.BSN = BSN;
            this.hourlyWage = hourlyWage;
            this.employeeID = employeeID;
            this.dateOfBirth = dateOfBirth;
            this.password = password;
            this.contract = contract;
            this.role = role;
            status = 1;
            departmentID = 0;

        }

        public Employee(string firstName, string surname, string email, string phoneNumber, string address, int BSN, decimal hourlyWage, int employeeID, DateTime dateOfBirth, string password, Role role, double contract, int status, int departmentID)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.BSN = BSN;
            this.hourlyWage = hourlyWage;
            this.employeeID = employeeID;
            this.dateOfBirth = dateOfBirth;
            this.password = password;
            this.role = role;
            this.contract = contract;
            this.status = status;
            this.departmentID = departmentID;

        }

        public int GetAccessLevel()
        {
            return role.GetAccessLevel();
        }
        public int GetDepartmentID()
        {
            return departmentID;
        }
        public void SetDepartmentID(int departmentID)
        {
            this.departmentID = departmentID;
        }
        public void SetFirstName(string firstName) 
        {
            this.firstName = firstName;          
        }
        public void SetLastName(string lastName)
        {
            this.surname = lastName;
        }
        public void SetEmail(string email)
        {
            this.email = email;

        }
        public void SetPhoneNr(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;

        }
        public void SetAddress(string address)
        {
            this.address = address;

        }
        public void SetPassword(string password)
        {
            this.password = password;

        }
        public void SetHourlyWage(int hourlyWage)
        {
            this.hourlyWage = hourlyWage;

        }
        public void SetBSN(int BSN)
        {
            this.BSN = BSN;

        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;

        }
        public void SetRole(Role role)
        {
            this.role = role;

        }
        public void SetEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;

        }
        public void SetContract(double contract)
        {
            this.contract = contract;
        }
       
        public void SetStatus(int status)
        {
            this.status = status;
        }

        public string GetFirstName()
        {
            return firstName;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetEmailAddress()
        {
            return this.email;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public int GetEmployeeID()
        {
            return employeeID;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }
        public int GetBSN() 
        {
            return BSN;
        }
        public decimal GetHourlyWage() 
        {
            return hourlyWage;
        }
        public int GetRoleID()
        {
            return role.GetRoleID();
        }
        public string GetPassword()
        {
            return this.password;
        }

        public double GetContract()
        {
            return this.contract;
        }

       

        public override string ToString()
        {
            return $"{this.employeeID} {this.firstName} {this.surname} {this.email}";
        }
        public string GetBasicInfo()
        {
            return $"{this.employeeID} {this.firstName} {this.surname} {this.email}";
        }
        public string GetBasicInfoStatus()
        {
            if(this.status == 1)
            {
                return $"{this.employeeID} {this.firstName} {this.surname} {this.email} (active)";
            }

            else
            {
                return $"{this.employeeID} {this.firstName} {this.surname} {this.email} (inactive)";
            }
        }

        public string GetEmpRoleName()
        {
            return role.GetRoleName();
        }

        public int GetStatus()
        {
            return status;
        }

        public void UpdateUnavailableShifts()
        {
            this.unavailableShifts = dbcon.ReadAllUnavailableShiftsByEmployeeID(employeeID);
        }
        public bool AddUnavailableShift(UnavailableShift us)
        {
            unavailableShifts.Add(us);
            return true;
        }
        public List<UnavailableShift> GetUnavailableShifts()
        {
            return unavailableShifts;
        }



    }
}
