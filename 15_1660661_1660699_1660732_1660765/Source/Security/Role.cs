using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class Role
    {
        //int roleID;
        private int roleID;

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        private string roleName;

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
       

        public static List<Role> LoadAllRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection sqlConn = DataProvider.ConnectDatabase())
            {
                string selectSql = "select * from Roles";
                SqlCommand sqlCommand = new SqlCommand(selectSql, sqlConn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while(sqlDataReader.Read())
                    {
                        Role role = new Role()
                        {
                            RoleID = sqlDataReader.GetInt32(0),
                            RoleName = sqlDataReader.GetString(1)
                        };
                        roles.Add(role);
                    }
                }
                return roles;
            }
        }
    }
}
