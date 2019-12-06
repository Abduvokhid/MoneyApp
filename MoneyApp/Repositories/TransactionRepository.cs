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
    class TransactionRepository
    {
        private static TransactionRepository instance;
        private TransactionRepository() { }

        public static TransactionRepository Instance()
        {
            if (instance == null)
            {
                instance = new TransactionRepository();
            }
            return instance;
        }
        public List<Transaction> GetUserTransactions(int id)
        {
            List<Transaction> transactions = new List<Transaction>();
            string query = "SELECT Transactions.*, Contacts.Name AS ContactName FROM Transactions LEFT JOIN Contacts ON Contacts.ID = Transactions.ContactID WHERE Transactions.UserID = @id";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Transaction transaction = new Transaction {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        ContactID = (int)sqlDataReader["ContactID"],
                        ContactName = sqlDataReader["ContactName"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Amount = (decimal)sqlDataReader["Amount"],
                        Note = sqlDataReader["Note"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["CreatedDate"],
                    };
                    // True - income, False - expense
                    transaction.TypeName = transaction.Type ? "Income" : "Expense";
                    transactions.Add(transaction);
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }
            return transactions;
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            string query = "DELETE FROM Transactions WHERE [UserID] = @UserID AND [ID] = @ID";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = transaction.ID;
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return (i > 0) ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddTransaction(Transaction transaction)
        {
            string query = "INSERT INTO Transactions ([UserID], [Name], [ContactID], [Type], [Amount], [Note], [CreatedDate]) VALUES (@UserID, @Name, @ContactID, @Type, @Amount, @Note, @CreatedDate)";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = transaction.Name;
                sqlCommand.Parameters.Add("@ContactID", SqlDbType.Int).Value = transaction.ContactID;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = transaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = transaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = transaction.CreatedDate;
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return (i > 0) ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditTransaction(Transaction transaction)
        {
            string query = "UPDATE Transactions SET [Name] = @Name, [ContactID] = @ContactID, [Type] = @Type, [Amount] = @Amount, [Note] = @Note, [CreatedDate] = @CreatedDate WHERE [ID] = @ID AND [UserID] = @UserID";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = transaction.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = transaction.Name;
                sqlCommand.Parameters.Add("@ContactID", SqlDbType.Int).Value = transaction.ContactID;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = transaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = transaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = transaction.CreatedDate;
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return (i > 0) ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
