using System;
using System.Data;
using System.Data.SqlClient;
using MoneyApp.Models;
using System.Configuration;
using bcrypt = BCrypt.Net.BCrypt;
using NLog;

namespace MoneyApp.Repositories
{
    class UserRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly UserRepository instance = new UserRepository();
        public static UserRepository Instance { get { return instance; } }

        public bool AddUser(User user)
        {
            const string query = "INSERT INTO Users([Name],[Username],[Password]) VALUES(@Name, @Username, @Password);";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;

                string my = bcrypt.GenerateSalt();

                var result = sqlCommand.ExecuteNonQuery();

                return (result > 0) ? true : false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Dispose();
            }
        }

        public User GetUserByUsername(string username)
        {
            User user = new User();
            string query = "SELECT * FROM Users WHERE [Username] = @Username";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    user.ID = (int)sqlDataReader["ID"];
                    user.Name = sqlDataReader["Name"].ToString();
                    user.Username = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                    user.LastAccessDate = (DateTime)sqlDataReader["LastAccessDate"];
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            finally
            {
                sqlConnection.Dispose();
            }

            return user;
        }

        public int EditLastAccessDate(User temporaryUser)
        {
            string query = "UPDATE Users SET [LastAccessDate] = @LastAccessDate WHERE [ID] = @ID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = temporaryUser.ID;
                sqlCommand.Parameters.Add("@LastAccessDate", SqlDbType.DateTime).Value = temporaryUser.LastAccessDate;

                var result = sqlCommand.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return 0;
            }
            finally
            {
                sqlConnection.Dispose();
            }
        }
    }
}
