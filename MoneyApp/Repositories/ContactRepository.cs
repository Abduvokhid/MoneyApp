using MoneyApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp.Repositories
{
    class ContactRepository
    {
        private static ContactRepository instance;
        private ContactRepository() { }

        public static ContactRepository Instance()
        {
            if (instance == null)
            {
                instance = new ContactRepository();
            }
            return instance;
        }


        public List<Contact> GetUserContacts(int id)
        {
            List<Contact> contacts = new List<Contact>();
            string query = "SELECT * FROM Contacts WHERE [UserID] = @id";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    contacts.Add(new Contact
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString()
                    });
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }
            return contacts;
        }

        public bool DeleteContact(Contact contact)
        {
            string query = "DELETE FROM Contacts WHERE [UserID] = @UserID AND [ID] = @ID";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contact.ID;
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                if (i > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int AddContact(Contact contact)
        {
            string query = "INSERT INTO Contacts ([UserID], [Name]) OUTPUT INSERTED.ID  VALUES (@UserID, @Name)";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int i = 0;
                while (sqlDataReader.Read())
                {
                    i = (int)sqlDataReader["ID"];
                }
                sqlConnection.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int EditContact(Contact contact)
        {
            string query = "UPDATE Contacts SET [Name] = @Name WHERE [ID] = @ID AND [UserID] = @UserID";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = contact.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = contact.ID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
