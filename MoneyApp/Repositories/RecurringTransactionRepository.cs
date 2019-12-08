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
    class RecurringTransactionRepository
    {
        private static RecurringTransactionRepository instance;
        private RecurringTransactionRepository() { }

        public static RecurringTransactionRepository Instance()
        {
            if (instance == null)
            {
                instance = new RecurringTransactionRepository();
            }
            return instance;
        }
        public List<RecurringTransaction> GetUserTransactions(int id)
        {
            List<RecurringTransaction> transactions = new List<RecurringTransaction>();
            string query = "SELECT RecurringTransactions.*, Contacts.Name AS ContactName FROM RecurringTransactions LEFT JOIN Contacts ON Contacts.ID = RecurringTransactions.ContactID WHERE RecurringTransactions.UserID = @id";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    RecurringTransaction transaction = new RecurringTransaction
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Amount = (decimal)sqlDataReader["Amount"],
                        Note = sqlDataReader["Note"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["CreatedDate"],
                        Status = sqlDataReader["Status"].ToString()
                    };

                    if (sqlDataReader["ContactID"] == DBNull.Value) transaction.ContactID = 0;
                    else transaction.ContactID = (int)sqlDataReader["ContactID"];
                    if (sqlDataReader["ContactName"] == DBNull.Value) transaction.ContactName = "";
                    else transaction.ContactName = sqlDataReader["ContactName"].ToString();
                    if (sqlDataReader["EndDate"] == DBNull.Value) transaction.EndDate = DateTime.MinValue;
                    else transaction.EndDate = (DateTime)sqlDataReader["EndDate"];

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

        public bool DeleteTransaction(RecurringTransaction transaction)
        {
            string query = "DELETE FROM RecurringTransactions WHERE [UserID] = @UserID AND [ID] = @ID";
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

        public bool AddTransaction(RecurringTransaction transaction)
        {
            string query = "INSERT INTO RecurringTransactions ([UserID], [Name], [ContactID], [Type], [Amount], [Note], [AddedDate], [Status], [EndDate]) VALUES (@UserID, @Name, @ContactID, @Type, @Amount, @Note, @CreatedDate, @Status, @EndDate)";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = transaction.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = transaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = transaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = transaction.CreatedDate;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = transaction.Status;

                SqlParameter ContactID = new SqlParameter("@ContactID", SqlDbType.Int);
                if (transaction.ContactID == 0) ContactID.Value = DBNull.Value;
                else ContactID.Value = transaction.ContactID;
                sqlCommand.Parameters.Add(ContactID);

                SqlParameter EndDate = new SqlParameter("@EndDate", SqlDbType.Int);
                if (transaction.EndDate == DateTime.MinValue) EndDate.Value = DBNull.Value;
                else EndDate.Value = transaction.EndDate;
                sqlCommand.Parameters.Add(EndDate);

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

        public bool EditTransaction(RecurringTransaction transaction)
        {
            string query = "UPDATE RecurringTransactions SET [Name] = @Name, [ContactID] = @ContactID, [Type] = @Type, [Amount] = @Amount, [Note] = @Note, [CreatedDate] = @CreatedDate, [Status] = @Status, [EndDate] = @EndDate WHERE [ID] = @ID AND [UserID] = @UserID";
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = transaction.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = transaction.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = transaction.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = transaction.Type;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = transaction.Note;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = transaction.CreatedDate;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = transaction.Status;

                SqlParameter ContactID = new SqlParameter("@ContactID", SqlDbType.Int);
                if (transaction.ContactID == 0) ContactID.Value = DBNull.Value;
                else ContactID.Value = transaction.ContactID;
                sqlCommand.Parameters.Add(ContactID);

                SqlParameter EndDate = new SqlParameter("@EndDate", SqlDbType.Int);
                if (transaction.EndDate == DateTime.MinValue) EndDate.Value = DBNull.Value;
                else EndDate.Value = transaction.EndDate;
                sqlCommand.Parameters.Add(EndDate);

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