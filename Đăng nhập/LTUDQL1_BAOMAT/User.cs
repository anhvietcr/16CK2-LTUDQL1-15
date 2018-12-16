using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL1_BAOMAT
{
    public class User
    {
        int userID;
        string userName;
        string hashPassword;
        string email;
        DateTime createdDate;
        List<Role> roles = new List<Role>();
        public int UserID { get { return userID;} set  {userID = value;} }
        public string UserName { get { return userName;} set {userName = value;} }
        public string HashPassword { get { return hashPassword;} set {hashPassword = value;} }
        public string Email { get { return email;} set { email = value; } }
        public DateTime CreatedDate { get {return createdDate;} set {createdDate = value;} }
        public List<Role> Roles { get { return roles;} set { roles = value; }}

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2"));
            }
            return hash.ToString();
        }

        public bool CreateUser()
        {
            try
            {
                using (SqlConnection sqlConn = DataProvider.ConnectDatabase())
                {

                    string insertUserSQL = "INSERT INTO Users(UserName, Password, Email, CreatedDate) VALUES (@username, @password, @email, @createdDate)";
                    SqlCommand sqlCommand = new SqlCommand(insertUserSQL, sqlConn);

                    SqlParameter sqlParameter = new SqlParameter("username", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = UserName;
                    sqlCommand.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("password", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = HashPassword;
                    sqlCommand.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("email", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = Email;
                    sqlCommand.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("createdDate", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = DateTime.Now;
                    sqlCommand.Parameters.Add(sqlParameter);

                    sqlCommand.ExecuteNonQuery();

                    DataProvider.CloseConnection(sqlConn);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool Authenticate()
        {
            try
            {
                using (SqlConnection sqlConn = DataProvider.ConnectDatabase())
                {
                    string selectUserSQL = "select * from Users where UserName=@username AND Password=@password";
                    SqlCommand sqlCommand = new SqlCommand(selectUserSQL, sqlConn);

                    SqlParameter sqlParameter = new SqlParameter("username", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = UserName;
                    sqlCommand.Parameters.Add(sqlParameter);

                    sqlParameter = new SqlParameter("password", System.Data.SqlDbType.VarChar);
                    sqlParameter.Value = HashPassword;
                    sqlCommand.Parameters.Add(sqlParameter);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        UserID = sqlDataReader.GetInt32(0);
                     
                        LoadRoles(Role.LoadAllRoles());
                        return true;                        
                    }

                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void LoadRoles(List<Role> AllRoles)
        {
            try
            {
                using (SqlConnection sqlConn = DataProvider.ConnectDatabase())
                {
                    string selectUserSQL = "select RoleID from RoleAssigns where UserID=@userID";
                    SqlCommand sqlCommand = new SqlCommand(selectUserSQL, sqlConn);

                    SqlParameter sqlParameter = new SqlParameter("userID", System.Data.SqlDbType.Int);
                    sqlParameter.Value = UserID;
                    sqlCommand.Parameters.Add(sqlParameter);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        int roleID;
                        while(sqlDataReader.Read())
                        {
                            roleID = sqlDataReader.GetInt32(0);
                            Role role = AllRoles.Find(x => x.RoleID == roleID);
                            Roles.Add(role);
                        }                       
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
