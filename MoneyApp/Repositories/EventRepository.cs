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
    class EventRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly EventRepository instance = new EventRepository();
        public static EventRepository Instance { get { return instance; } }

        public List<Event> GetUserEvents(int userID)
        {
            string query = "SELECT Events.*, Contacts.Name AS ContactName FROM Events LEFT JOIN Contacts ON Contacts.ID = Events.ContactID WHERE Events.UserID = @UserID";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            List<Event> eventsList = new List<Event>();

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Event temporaryEvent = new Event
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Location = sqlDataReader["Location"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["AddedDate"],
                        Note = sqlDataReader["Note"].ToString()
                    };

                    if (sqlDataReader["ContactID"] == DBNull.Value)
                    {
                        temporaryEvent.ContactID = 0;
                    }
                    else
                    {
                        temporaryEvent.ContactID = (int)sqlDataReader["ContactID"];
                    }

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                    {
                        temporaryEvent.ContactName = "";
                    }
                    else
                    {
                        temporaryEvent.ContactName = sqlDataReader["ContactName"].ToString();
                    }


                    if (temporaryEvent.Type)
                    {
                        temporaryEvent.TypeName = "Appointment";
                    }
                    else
                    {
                        temporaryEvent.TypeName = "Task";
                    }

                    eventsList.Add(temporaryEvent);
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
            return eventsList;
        }
        
        public bool AddEvent(Event temporaryEvent)
        {
            string query = "INSERT INTO Events ([UserID],[Name],[Type],[Location],[AddedDate],[Note],[ContactID]) VALUES(@UserID,@Name,@Type,@Location,@CreatedDate,@Note,@ContactID);";
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = temporaryEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = temporaryEvent.Type;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = temporaryEvent.Location;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = temporaryEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = temporaryEvent.Note;
                
                SqlParameter eventContact = new SqlParameter("@ContactID", SqlDbType.Int);
                
                if (temporaryEvent.ContactID == 0)
                {
                    eventContact.Value = DBNull.Value;
                }
                else
                {
                    eventContact.Value = temporaryEvent.ContactID;
                }
                sqlCommand.Parameters.Add(eventContact);

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
        
        public bool DeleteEvent(Event temporaryEvent)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "Delete FROM Events WHERE [ID] = @ID and [UserID]=@UserID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = temporaryEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryEvent.UserID;
                
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
        
        public bool EditEvent(Event temporaryEvent)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            string query = "UPDATE Events SET [EventName] = @EventName,[EventType] = @EventType,[EventDateTime] = @EventDateTime,[EventLocation] = @EventLocation,[EventNote] = @EventNote, [FK_ContactID] = @FK_ContactID WHERE [FK_UserID] = @FK_UserID AND [EventID] = @EventID";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = temporaryEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = temporaryEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = temporaryEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = temporaryEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = temporaryEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = temporaryEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = temporaryEvent.Note;
                
                SqlParameter eventContact = new SqlParameter("@ContactID", SqlDbType.Int);
                if (temporaryEvent.ContactID == 0)
                {
                    eventContact.Value = DBNull.Value;
                }
                else
                {
                    eventContact.Value = temporaryEvent.ContactID;
                }
                sqlCommand.Parameters.Add(eventContact);

                sqlConnection.Open();

                var result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                    return true;

                else
                    return false;
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
