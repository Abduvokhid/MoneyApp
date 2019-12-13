using System;
using System.Data;
using System.Data.SqlClient;
using MoneyApp.Models;
using System.Configuration;
using bcrypt = BCrypt.Net.BCrypt;

namespace MoneyApp.Repositories
{
    class UserRepository
    {
        private static UserRepository instance;
        private UserRepository() { }

        public static UserRepository Instance()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }

        public bool AddUser(User user)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            const string query = "INSERT INTO Users([Name],[Username],[Password]) VALUES(@Name, @Username, @Password);";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;

                string my = bcrypt.GenerateSalt();

                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public User GetUserByUsername(string username)
        {
            User user = new User();
            string query = "SELECT * FROM Users WHERE [Username] = @Username";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    user.ID = (int)sqlDataReader["ID"];
                    user.Name = sqlDataReader["Name"].ToString();
                    user.Username = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                    user.LastAccessDate = (DateTime)sqlDataReader["LastAccessDate"];
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }
    }
}
