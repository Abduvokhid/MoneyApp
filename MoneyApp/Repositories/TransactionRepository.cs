using MoneyApp.Models;
using NLog;
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
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly TransactionRepository instance = new TransactionRepository();
        public static TransactionRepository Instance { get { return instance; } }

        public List<Transaction> GetUserTransactions(int id)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            string query = "SELECT Transactions.*, Contacts.Name AS ContactName FROM Transactions LEFT JOIN Contacts ON Contacts.ID = Transactions.ContactID WHERE Transactions.UserID = @id";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Transaction temporaryTransaction = new Transaction {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Amount = (decimal)sqlDataReader["Amount"],
                        Note = sqlDataReader["Note"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["AddedDate"],
                    };

                    temporaryTransaction.ContactID = (sqlDataReader["ContactID"] == DBNull.Value) ? 0 : (int)sqlDataReader["ContactID"];

                    temporaryTransaction.ContactName = (sqlDataReader["ContactName"] == DBNull.Value) ? "" : sqlDataReader["ContactName"].ToString();

                    temporaryTransaction.TypeName = temporaryTransaction.Type ? "Income" : "Expense";

                    transactionsList.Add(temporaryTransaction);
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

            return transactionsList;
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            string query = "DELETE FROM Transactions WHERE [UserID] = @UserID AND [ID] = @ID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = transaction.ID;

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

        public bool AddTransaction(Transaction temporaryTransaction)
        {
            string query = "INSERT INTO Transactions ([UserID], [Name], [ContactID], [Type], [Amount], [Note], [AddedDate]) VALUES (@UserID, @Name, @ContactID, @Type, @Amount, @Note, @CreatedDate)";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryTransaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = temporaryTransaction.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = temporaryTransaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = temporaryTransaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = temporaryTransaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = temporaryTransaction.CreatedDate;

                SqlParameter transactionContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryTransaction.ContactID == 0) transactionContact.Value = DBNull.Value;
                else transactionContact.Value = temporaryTransaction.ContactID;
                sqlCommand.Parameters.Add(transactionContact);

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

        public bool EditTransaction(Transaction temporaryTransaction)
        {
            string query = "UPDATE Transactions SET [Name] = @Name, [ContactID] = @ContactID, [Type] = @Type, [Amount] = @Amount, [Note] = @Note, [AddedDate] = @CreatedDate WHERE [ID] = @ID AND [UserID] = @UserID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = temporaryTransaction.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryTransaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = temporaryTransaction.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = temporaryTransaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = temporaryTransaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = temporaryTransaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = temporaryTransaction.CreatedDate;

                SqlParameter transactionContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryTransaction.ContactID == 0) transactionContact.Value = DBNull.Value;
                else transactionContact.Value = temporaryTransaction.ContactID;
                sqlCommand.Parameters.Add(transactionContact);

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
    }
}
