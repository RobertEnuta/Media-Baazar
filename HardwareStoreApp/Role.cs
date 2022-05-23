using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class Role
    {
        private int roleID;
        private string name;
        private int accessLevel;

        public Role(int roleID, string name, int accessLevel)
        {
            this.roleID = roleID;
            this.name = name;
            this.accessLevel = accessLevel;
        }

        public string GetRoleName()
        {
            return name;
        }

        public int GetRoleID()
        {
            return roleID;
        }

        public int GetAccessLevel()
        {
            return accessLevel;
        }

        public override string ToString()
        {
            if (accessLevel == 5)
            {
                return name + " Access level: " + "2 " + roleID;
            }
            else if (accessLevel == 6)
            {
                return name + " Access level: " + "3 " + roleID;
            }
            if (accessLevel == 10)
            {
                return name + " Access level: " + "4 " + roleID;
            }
            else 
            { 
                return name + " Access level: " + Convert.ToString(accessLevel) + " " + roleID;
            }

        }

    }
}
