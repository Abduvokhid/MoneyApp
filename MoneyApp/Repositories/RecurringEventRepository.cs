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
    class RecurringEventRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly RecurringEventRepository instance = new RecurringEventRepository();
        public static RecurringEventRepository Instance { get { return instance; } }
        
        public List<RecurringEvent> GetRecurringEvents(int userID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "SELECT RecurringEvents.*, Contacts.Name AS ContactName FROM RecurringEvents LEFT JOIN Contacts ON Contacts.ID = RecurringEvents.ContactID WHERE RecurringEvents.UserID = @UserID";

            List<RecurringEvent> recurringEventsList = new List<RecurringEvent>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    RecurringEvent temporaryEvent = new RecurringEvent
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Location = sqlDataReader["Location"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["AddedDate"],
                        Note = sqlDataReader["Note"].ToString(),
                        Status = sqlDataReader["Status"].ToString(),
                    };

                    temporaryEvent.TypeName = temporaryEvent.Type ? "Appointment" : "Task";

                    temporaryEvent.ContactID = (sqlDataReader["ContactID"] == DBNull.Value) ? 0 : temporaryEvent.ContactID = (int)sqlDataReader["ContactID"];

                    temporaryEvent.ContactName = (sqlDataReader["ContactName"] == DBNull.Value) ? "" : temporaryEvent.ContactName = sqlDataReader["ContactName"].ToString();

                    temporaryEvent.EndDate = (sqlDataReader["EndDate"] == DBNull.Value) ? DateTime.MinValue : temporaryEvent.EndDate = (DateTime)sqlDataReader["EndDate"];

                    recurringEventsList.Add(temporaryEvent);
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

            return recurringEventsList;
        }
        
        public bool AddRecurringEvent(RecurringEvent temporaryEvent)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "INSERT INTO RecurringEvents ([UserID],[Name],[Type],[AddedDate],[Location],[Note],[Status],[EndDate],[ContactID]) VALUES(@UserID,@Name,@Type,@CreatedDate,@Location,@Note,@Status,@EndDate,@ContactID);";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = temporaryEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = temporaryEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = temporaryEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = temporaryEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = temporaryEvent.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = temporaryEvent.Status;

                SqlParameter eventContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryEvent.ContactID == 0) eventContact.Value = DBNull.Value;
                else eventContact.Value = temporaryEvent.ContactID;
                sqlCommand.Parameters.Add(eventContact);
                
                SqlParameter eventEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
                if (temporaryEvent.EndDate == DateTime.MinValue) eventEndDate.Value = DBNull.Value;
                else eventEndDate.Value = temporaryEvent.EndDate;
                sqlCommand.Parameters.Add(eventEndDate);
                
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
        
        public bool DeleteRecurringEvent(RecurringEvent objectrecEvent)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "Delete FROM RecurringEvents WHERE [ID] = @ID and [UserID]=@UserID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectrecEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectrecEvent.UserID;

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
        
        public bool EditRecurringEvent(RecurringEvent objectEditrecEvent)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "UPDATE RecurringEvents SET [Name] = @Name,[Type] = @Type,[AddedDate] = @CreatedDate,[Location] = @Location,[Note] = @Note,[Status] = @Status,[ContactID] = @ContactID,[EndDate] = @EndDate WHERE [UserID] = @UserID AND [ID] = @ID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectEditrecEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectEditrecEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = objectEditrecEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = objectEditrecEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = objectEditrecEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = objectEditrecEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = objectEditrecEvent.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = objectEditrecEvent.Status;

                SqlParameter eventContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (objectEditrecEvent.ContactID == 0) eventContact.Value = DBNull.Value;
                else eventContact.Value = objectEditrecEvent.ContactID;
                sqlCommand.Parameters.Add(eventContact);


                SqlParameter eventEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);
                if (objectEditrecEvent.EndDate == DateTime.MinValue) eventEndDate.Value = DBNull.Value;
                else eventEndDate.Value = objectEditrecEvent.EndDate;
                sqlCommand.Parameters.Add(eventEndDate);

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
