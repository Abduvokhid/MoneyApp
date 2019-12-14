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
    class RecurringEventRepository
    {
        private static RecurringEventRepository instance;
        private RecurringEventRepository() { }

        public static RecurringEventRepository Instance()
        {
            if (instance == null)
            {
                instance = new RecurringEventRepository();
            }
            return instance;
        }


        // read all RecurringEvent
        public List<RecurringEvent> GetRecEvents(int userID)
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);

            // object recEventList
            List<RecurringEvent> recEventList = new List<RecurringEvent>();

            string selectRecEventQuery = "SELECT RecurringEvents.*, Contacts.Name AS ContactName FROM RecurringEvents LEFT JOIN Contacts ON Contacts.ID = RecurringEvents.ContactID WHERE RecurringEvents.UserID = @UserID";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectRecEventQuery, sqlConnection);

                sqlCommand.Parameters.Add("@FK_UserID", SqlDbType.Int).Value = userID;


                sqlConnection.Open();
                // Ask to retrieve all the  row
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                while (sqlDataReader.Read())
                {
                    RecurringEvent temp = new RecurringEvent
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


                    if (temp.Type)
                    {// appointment=1-TRUE
                        temp.TypeName = "Appointment";
                    }
                    else
                    {// task=0-FALSE
                        temp.TypeName = "Task";
                    }



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

                    if (sqlDataReader["EndDate"] == DBNull.Value)
                    {
                        temp.EndDate = DateTime.MinValue;
                    }
                    else
                    {
                        temp.EndDate = (DateTime)sqlDataReader["EndDate"];
                    }


                    recEventList.Add(temp);


                }
                sqlConnection.Close();


            }
            catch (Exception ex)
            {
                sqlConnection.Close();
            }


            return recEventList;
        }


        //Add RecurringEvent
        public bool AddrecEvents(RecurringEvent objectrecEvent)
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            //Add Events query
            string sqlAddrecEventQuery = "INSERT INTO RecurringEvents ([UserID],[Name],[Type],[AddedDate],[Location],[Note],[Status],[EndDate],[ContactID]) VALUES(@UserID,@Name,@Type,@CreatedDate,@Location,@Note,@Status,@EndDate,@ContactID);";


            try
            {
                SqlCommand sqlCommand = new SqlCommand(sqlAddrecEventQuery, sqlConnection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectrecEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = objectrecEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = objectrecEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = objectrecEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = objectrecEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = objectrecEvent.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = objectrecEvent.Status;

                SqlParameter contactparameter = new SqlParameter("@ContactID", SqlDbType.Int);

                if (objectrecEvent.ContactID == 0)
                {
                    contactparameter.Value = DBNull.Value;
                }
                else
                {
                    contactparameter.Value = objectrecEvent.ContactID;
                }
                sqlCommand.Parameters.Add(contactparameter);


                SqlParameter eventEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);

                if (objectrecEvent.EndDate == DateTime.MinValue)
                {
                    eventEndDate.Value = DBNull.Value;
                }
                else
                {
                    eventEndDate.Value = objectrecEvent.EndDate;
                }
                sqlCommand.Parameters.Add(eventEndDate);
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

        //Delete RecurringEvent
        public bool DeleterecEvent(RecurringEvent objectrecEvent)
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            string DeleteRecEventQuery = "Delete FROM RecurringEvents WHERE [ID] = @ID and [UserID]=@UserID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(DeleteRecEventQuery, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectrecEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectrecEvent.UserID;

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

        //Edit RecurringEvent
        public bool EditrecEvent(RecurringEvent objectEditrecEvent)
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString);
            string EditRecEventnQuery = "UPDATE RecurringEvents SET [Name] = @Name,[Type] = @Type,[AddedDate] = @CreatedDate,[Location] = @Location,[Note] = @Note,[Status] = @Status,[ContactID] = @ContactID,[EndDate] = @EndDate WHERE [UserID] = @UserID AND [ID] = @ID";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(EditRecEventnQuery, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = objectEditrecEvent.ID;
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = objectEditrecEvent.UserID;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = objectEditrecEvent.Name;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = objectEditrecEvent.Type;
                sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = objectEditrecEvent.CreatedDate;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = objectEditrecEvent.Location;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar).Value = objectEditrecEvent.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = objectEditrecEvent.Status;


                SqlParameter contactparameter = new SqlParameter("@ContactID", SqlDbType.Int);


                //
                if (objectEditrecEvent.ContactID == 0)
                {
                    contactparameter.Value = DBNull.Value;
                }
                else
                {
                    contactparameter.Value = objectEditrecEvent.ContactID;
                }
                sqlCommand.Parameters.Add(contactparameter);


                SqlParameter eventEndDate = new SqlParameter("@EndDate", SqlDbType.DateTime);

                if (objectEditrecEvent.EndDate == DateTime.MinValue)
                {
                    eventEndDate.Value = DBNull.Value;
                }
                else
                {
                    eventEndDate.Value = objectEditrecEvent.EndDate;
                }
                sqlCommand.Parameters.Add(eventEndDate);
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
