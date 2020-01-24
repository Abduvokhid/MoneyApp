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
    class RecurringTransactionRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly RecurringTransactionRepository instance = new RecurringTransactionRepository();
        public static RecurringTransactionRepository Instance { get { return instance; } }

        public List<RecurringTransaction> GetUserTransactions(int id)
        {
            List<RecurringTransaction> recurringTransactionsList = new List<RecurringTransaction>();
            string query = "SELECT RecurringTransactions.*, Contacts.Name AS ContactName FROM RecurringTransactions LEFT JOIN Contacts ON Contacts.ID = RecurringTransactions.ContactID WHERE RecurringTransactions.UserID = @id";
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
                    RecurringTransaction temporaryTransaction = new RecurringTransaction
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Amount = (decimal)sqlDataReader["Amount"],
                        Note = sqlDataReader["Note"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["AddedDate"],
                        Status = sqlDataReader["Status"].ToString()
                    };

                    temporaryTransaction.ContactID = (sqlDataReader["ContactID"] == DBNull.Value) ? 0 : (int)sqlDataReader["ContactID"];

                    temporaryTransaction.ContactName = (sqlDataReader["ContactName"] == DBNull.Value) ? "" : sqlDataReader["ContactName"].ToString();

                    temporaryTransaction.EndDate = (sqlDataReader["EndDate"] == DBNull.Value) ? DateTime.MinValue : (DateTime)sqlDataReader["EndDate"];

                    temporaryTransaction.TypeName = temporaryTransaction.Type ? "Income" : "Expense";

                    recurringTransactionsList.Add(temporaryTransaction);
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
            return recurringTransactionsList;
        }

        public bool DeleteTransaction(RecurringTransaction temporaryTransaction)
        {
            string query = "DELETE FROM RecurringTransactions WHERE [UserID] = @UserID AND [ID] = @ID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryTransaction.UserID;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = temporaryTransaction.ID;

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

        public bool AddTransaction(RecurringTransaction temporaryTransaction)
        {
            string query = "INSERT INTO RecurringTransactions ([UserID], [Name], [ContactID], [Type], [Amount], [Note], [AddedDate], [Status], [EndDate]) VALUES (@UserID, @Name, @ContactID, @Type, @Amount, @Note, @CreatedDate, @Status, @EndDate)";
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
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = temporaryTransaction.Status;

                SqlParameter transactionContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryTransaction.ContactID == 0) transactionContact.Value = DBNull.Value;
                else transactionContact.Value = temporaryTransaction.ContactID;
                sqlCommand.Parameters.Add(transactionContact);

                SqlParameter transactionEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
                if (temporaryTransaction.EndDate == DateTime.MinValue) transactionEndDate.Value = DBNull.Value;
                else transactionEndDate.Value = temporaryTransaction.EndDate;
                sqlCommand.Parameters.Add(transactionEndDate);

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

        public bool EditTransaction(RecurringTransaction temporaryTransaction)
        {
            string query = "UPDATE RecurringTransactions SET [Name] = @Name, [ContactID] = @ContactID, [Type] = @Type, [Amount] = @Amount, [Note] = @Note, [AddedDate] = @CreatedDate, [Status] = @Status, [EndDate] = @EndDate WHERE [ID] = @ID AND [UserID] = @UserID";
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
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = temporaryTransaction.Status;

                SqlParameter transactionContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryTransaction.ContactID == 0) transactionContact.Value = DBNull.Value;
                else transactionContact.Value = temporaryTransaction.ContactID;
                sqlCommand.Parameters.Add(transactionContact);

                SqlParameter transactionEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
                if (temporaryTransaction.EndDate == DateTime.MinValue) transactionEndDate.Value = DBNull.Value;
                else transactionEndDate.Value = temporaryTransaction.EndDate;
                sqlCommand.Parameters.Add(transactionEndDate);

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