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
        private static EventRepository instance;
        private EventRepository() { }

        public static EventRepository Instance()
        {
            if (instance == null)
            {
                instance = new EventRepository();
            }
            return instance;
        }
        // read all events
        public List<Event> GetUserEvents(int userID)
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            // object eventList
            List<Event> eventList = new List<Event>();

            string selectEventQuery = "SELECT Events.*, Contacts.Name AS ContactName FROM Events LEFT JOIN Contacts ON Contacts.ID = Events.ContactID WHERE Events.UserID = @UserID";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectEventQuery, sqlConnection);

                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;


                sqlConnection.Open();
                // Ask to retrieve all the  row
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                while (sqlDataReader.Read())
                {
                    Event temp = new Event
                    {
                        ID = (int)sqlDataReader["ID"],
                        UserID = (int)sqlDataReader["UserID"],
                        Name = sqlDataReader["Name"].ToString(),
                        Type = (bool)sqlDataReader["Type"],
                        Location = sqlDataReader["Location"].ToString(),
                        CreatedDate = (DateTime)sqlDataReader["AddedDate"],
                        Note = sqlDataReader["Note"].ToString()
                    };

                    //check if needs add contact

                    if (sqlDataReader["ContactID"] == DBNull.Value)
                    {
                        temp.ContactID = 0;
                    }
                    else
                    {
                        temp.ContactID = (int)sqlDataReader["ContactID"];
                    }

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                    {
                        temp.ContactName = "";
                    }
                    else
                    {
                        temp.ContactName = sqlDataReader["ContactName"].ToString();
                    }


                    if (temp.Type)
                    {// appointment=1-TRUE
                        temp.TypeName = "Appointment";
                    }
                    else
                    {// task=0-FALSE
                        temp.TypeName = "Task";
                    }
                    eventList.Add(temp);


                }
                sqlConnection.Close();


            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                sqlConnection.Close();
            }


            return eventList;
        }


        //Add Event
        public bool AddEvent(Event objectEvent)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            //Add Event query
            string sqlAddEventQuery = "INSERT INTO Events ([UserID],[Name],[Type],[Location],[AddedDate],[Note],[ContactID]) VALUES(@UserID,@Name,@Type,@Location,@CreatedDate,@Note,@ContactID);";


            try
            {
                SqlCommand sqlCommand = new SqlCommand(sqlAddEventQuery, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = objectEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = objectEvent.Type;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = objectEvent.Location;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = objectEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = objectEvent.Note;


                SqlParameter contactparameter = new SqlParameter("@ContactID", SqlDbType.Int);


                //
                if (objectEvent.ContactID == 0)
                {
                    contactparameter.Value = DBNull.Value;
                }
                else
                {
                    contactparameter.Value = objectEvent.ContactID;
                }
                sqlCommand.Parameters.Add(contactparameter);


                sqlConnection.Open();


                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    sqlConnection.Close();
                    return true;

                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }

        }

        //Delete Event
        public bool DeleteEvent(Event objectEvent)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            string DeleteEventQuery = "Delete FROM Events WHERE [ID] = @ID and [UserID]=@UserID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(DeleteEventQuery, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectEvent.UserID;

                sqlConnection.Open();

                var result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }

        }

        //Edit Event

        public bool EditEvent(Event objectEditEvent)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            string EditEventQuery = "UPDATE Events SET [EventName] = @EventName,[EventType] = @EventType,[EventDateTime] = @EventDateTime,[EventLocation] = @EventLocation,[EventNote] = @EventNote, [FK_ContactID] = @FK_ContactID WHERE [FK_UserID] = @FK_UserID AND [EventID] = @EventID";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(EditEventQuery, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectEditEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectEditEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = objectEditEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = objectEditEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = objectEditEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = objectEditEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = objectEditEvent.Note;


                SqlParameter contactparameter = new SqlParameter("@ContactID", SqlDbType.Int);


                //
                if (objectEditEvent.ContactID == 0)
                {
                    contactparameter.Value = DBNull.Value;
                }
                else
                {
                    contactparameter.Value = objectEditEvent.ContactID;
                }
                sqlCommand.Parameters.Add(contactparameter);

                sqlConnection.Open();

                var result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;

                else
                    return false;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }



        }
    }
}
