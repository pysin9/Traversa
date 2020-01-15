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
                


                user = new TravellerProfile(id, name, Email,  foodpref, language);
                

            }
            return user;
        }

        public int UpdatePassword(int UserID, string psd)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET Password = @paraPassword where UserID =  @paraUserId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraPassword", UserID);
            sqlCmd.Parameters.AddWithValue("@paraUserId", psd);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int UpdateProfile(TravellerProfile tv)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Travellers SET Username = @paraUsername, Email = @paraEmail, Langauge = @paraLanguage, FoodPref = @paraFoodPref where UserID =  @paraUserId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

           // sqlCmd.Parameters.AddWithValue("@paraUsername", tv.UserID);
            sqlCmd.Parameters.AddWithValue("@paraUsername", tv.Name);
            sqlCmd.Parameters.AddWithValue("@paraEmail", tv.Email);
            sqlCmd.Parameters.AddWithValue("@paraLanguage", tv.Language);
            sqlCmd.Parameters.AddWithValue("@paraFoodPref", tv.FoodPref);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        
    }
}