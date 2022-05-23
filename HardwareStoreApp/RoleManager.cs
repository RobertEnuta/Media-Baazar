using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public class RoleManager
    {
        private List<Role> RoleList = new List<Role>();

        private DBConnectionClass DBConnectionClass;

        public RoleManager()
        {
            DBConnectionClass = new DBConnectionClass();
            loadDataFromDatabaseRole();
        }

        public void loadDataFromDatabaseRole()
        {
            RoleList = new List<Role>();

            foreach (Role o in (List<Role>)DBConnectionClass.ReadAllFromRole())
            {
                RoleList.Add((Role)o);
            }
        }
        
        public void Add(Role role)
        {
            try
            {
                DBConnectionClass.InsertRole((Role)role);
                loadDataFromDatabaseRole();
            }
            catch (AddingToDBFailedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public Role GetRole(string roleName)
        {
            for (int counter = 0; counter < RoleList.Count; counter++)
            {
                if (RoleList[counter].GetRoleName() == roleName)
                {
                    return RoleList[counter];
                }

            }
            return null;
        }

        public void Update(Role role)
        {
            try
            {
                DBConnectionClass.UpdateRole(role);
                loadDataFromDatabaseRole();
            }
            catch (AddingToDBFailedException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }        

        public Role FindRole(string RoleName)
        {
            for (int counter = 0; counter < RoleList.Count; counter++)
            {
                if (RoleList[counter].GetRoleName() == RoleName)
                {
                    return RoleList[counter];
                }

            }
            return null;
        }

        

        public List<Role> GetRoles()
        {
            loadDataFromDatabaseRole();

            return RoleList;
        }

        public void SetRoles(List<Role> DBInput)
        {
            RoleList = DBInput;
        }

    }
}
