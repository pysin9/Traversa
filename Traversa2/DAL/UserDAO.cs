using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Traversa2.DAL
{
    public class UserDAO
    {
        public int Insert(Travellers u)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Travellers (Username,Password,Email) " +
                "VALUES (@paraName,@paraPassword, @paraEmail)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", u.Name);
            sqlCmd.Parameters.AddWithValue("@paraPassword", u.Password);
            sqlCmd.Parameters.AddWithValue("@paraEmail", u.Email);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public TravellerProfile SelectByEmail(string email)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Travellers where Email = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            DataSet ds = new DataSet();
            da.Fill(ds);

            TravellerProfile user = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = Convert.ToInt32(row["UserId"]);
                string name = row["Username"].ToString();
                string Email = row["Email"].ToString();
                string password = row["Password"].ToString();
                string foodpref = row["FoodPref"].ToString();
                string language = row["Language"].ToString();
                string style = row["Style"].ToString();
                int isHost = Convert.ToInt32(row["IsHost"]);


                user = new TravellerProfile(id, name, password, Email, foodpref, language, style, isHost);


            }
            return user;
        }

        public int UpdatePassword(int UserID, string psd)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET Password = @parapass where UserId =  @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", UserID);
            sqlCmd.Parameters.AddWithValue("@parapass", psd);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int UpdateProfile(TravellerProfile tv)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET Username = @parauname, Email = @paramail, Language = @paralang, FoodPref = @parafp, Style = @parasty where UserId =  @parauserid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@parauserid", tv.ID);
            sqlCmd.Parameters.AddWithValue("@parauname", tv.Name);
            sqlCmd.Parameters.AddWithValue("@paramail", tv.Email);
            sqlCmd.Parameters.AddWithValue("@paralang", tv.Language);
            sqlCmd.Parameters.AddWithValue("@parafp", tv.FoodPref);
            sqlCmd.Parameters.AddWithValue("@parasty", tv.Style);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public TravellerProfile SelectById(int ID)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Travellers where UserId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", ID);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            TravellerProfile tv = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = Convert.ToInt32(row["UserId"]);
                string name = row["Username"].ToString();
                string email = row["Email"].ToString();
                string foodpref = row["FoodPref"].ToString();
                string language = row["Language"].ToString();
                string style = row["Style"].ToString();
                tv = new TravellerProfile(id, name, email, foodpref, language, style);
            }
            return tv;
        }


        /*public int UpdateHostInfo(TravellerProfile tv)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET Email = @paramail, Description = @parahdesc, Reason = @parahreason where UserId = @parauserid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@parauserid", tv.ID);
            sqlCmd.Parameters.AddWithValue("@paramail", tv.Email);
            sqlCmd.Parameters.AddWithValue("@parahdesc", tv.Description);
            sqlCmd.Parameters.AddWithValue("@parahreason", tv.Reason);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }*/

        public int UpdateHostInfo(TravellerProfile tv)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET isHost = 1 where Email = @paramail";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paramail", tv.Email);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        /* public TravellerProfile SelectByIdHost(int ID)
         {
             string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
             SqlConnection myConn = new SqlConnection(DBConnect);

             string sqlstmt = "SELECT Email, Description, Reason From Travellers where UserId = @paraId";
             SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
             da.SelectCommand.Parameters.AddWithValue("@paraId", ID);

             DataSet ds = new DataSet();
             da.Fill(ds);
             int rec_cnt = ds.Tables[0].Rows.Count;

             TravellerProfile tv = null;
             if (rec_cnt > 0)
             {
                 DataRow row = ds.Tables[0].Rows[0];
                 int id = Convert.ToInt32(row["UserId"]);
                 string email = row["Email"].ToString();
                 string description = row["Description"].ToString();
                 string reason = row["Reason"].ToString();


                 TravellerProfile objRate = new TravellerProfile(id, email, description, reason);


             }
             return tv;
         } */

        public int DeleteHostAppl(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Description, Reason From Travellers where UserId = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", id);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

    }
}