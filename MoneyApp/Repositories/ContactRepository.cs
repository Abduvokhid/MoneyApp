using MoneyApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace MoneyApp.Repositories
{
    
    class ContactRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly ContactRepository instance = new ContactRepository();
        public static ContactRepository Instance { get { return instance; } }


        public List<Contact> GetUserContacts(int id)
        {
            string query = "SELECT * FROM Contacts WHERE [UserID] = @id";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            List<Contact> contactsList = new List<Contact>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    contactsList.Add(new Contact
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString()
                    });
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
            return contactsList;
        }

        public bool DeleteContact(Contact contact)
        {
            string query = "DELETE FROM Contacts WHERE [UserID] = @UserID AND [ID] = @ID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contact.ID;
                var i = sqlCommand.ExecuteNonQuery();

                return (i > 0) ? true : false;
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

        public int AddContact(Contact contact)
        {
            string query = "INSERT INTO Contacts ([UserID], [Name]) OUTPUT INSERTED.ID  VALUES (@UserID, @Name)";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int result = 0;
                while (sqlDataReader.Read())
                {
                    result = (int)sqlDataReader["ID"];
                }
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

        public int EditContact(Contact contact)
        {
            string query = "UPDATE Contacts SET [Name] = @Name WHERE [ID] = @ID AND [UserID] = @UserID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contact.ID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;
                sqlConnection.Open();
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
