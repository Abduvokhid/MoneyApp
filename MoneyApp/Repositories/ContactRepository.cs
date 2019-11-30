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
        public ContactRepository() { }


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
    }
}
