using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
   public class Account
    {
		private string username;
		private string password;
		private int accountId;
		private int employeeId;
		private bool accountType;//admin or normal employee 
		private static int accountNumberSeeder = 10000;

		public Account(string username, string password, int accountId, int employeeId, bool accountType)
		{
			this.username = username;
			this.password = password;
			this.accountId = accountId;
			this.employeeId = employeeId;
			this.accountType = accountType;
			this.accountId = accountId;
		}

		public string GetUsername()
		{
			return username;
		}

		public string GetPassword()
		{
			return password;
		}
		public int GetEmployeeId()
		{
			return employeeId;
		}
		public int GeAccountId()
		{
			return accountId;
		}

		public bool GetAccountType()//if the user has admin rights or not
		{
		
			return accountType;
		}

		public string GetInfo()
		{
			string adminOrNot;
			if (this.accountType == true)
			{
				adminOrNot = "Admin";
			}
			else
			{
				adminOrNot = "Employee";
			}
			return username + " " + employeeId + " " + accountId + " " + adminOrNot + " " + password;
		}

	}
}
    

