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
    public class RatingDAO
    {
        public int Insert(Rating rate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Rating (UserId, PlaceId, Rating, Review, DateTime) VALUES (@parauserid, @paraplaceid, @pararate, @parareview, @paradate)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@pararate", rate.Rate);
            sqlCmd.Parameters.AddWithValue("@parareview", rate.Review);
            sqlCmd.Parameters.AddWithValue("@parauserid", rate.UserId);
            sqlCmd.Parameters.AddWithValue("@paraplaceid", rate.PlaceId);
            sqlCmd.Parameters.AddWithValue("@paradate", rate.Date);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<Rating> GetAllOnPlaceId(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT Rating.UserId, PlaceId, Rating, Review, DateTime, Username FROM Rating INNER JOIN Travellers ON Rating.UserId = Travellers.UserId WHERE PlaceId = " + id + "";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Rating> recList = new List<Rating>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string username = Convert.ToString(row["Username"]);
                    string date = Convert.ToString(row["DateTime"]);
                    int placeid = Convert.ToInt32(row["PlaceId"]);
                    int userid = Convert.ToInt32(row["UserId"]);
                    int rate = Convert.ToInt32(row["Rating"]);
                    string review = Convert.ToString(row["Review"]);
                    Rating objRate = new Rating(rate, review, userid, placeid, username, date);
                    recList.Add(objRate);
                }
            }
            return recList;
        }

        public Rating RetrieveOne(int userid, int placeid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT Rating, Review From Rating where UserId = @paraId AND PlaceId = @paraplace";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", userid);
            da.SelectCommand.Parameters.AddWithValue("@paraplace", placeid);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Rating rating = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int rate = Convert.ToInt32(row["Rating"]);
                string review = Convert.ToString(row["Review"]);
                rating = new Rating(rate, review);
            }
            return rating;
        }

        public int UpdateReview(Rating rate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Rating SET Rating = @pararate, Review = @parareview, UserId = @parauserid, PlaceId = @paraplaceid, DateTime = @paradate where PlaceId =  @paraplaceid AND UserId = @parauserid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@pararate", rate.Rate);
            sqlCmd.Parameters.AddWithValue("@parareview", rate.Review);
            sqlCmd.Parameters.AddWithValue("@parauserid", rate.UserId);
            sqlCmd.Parameters.AddWithValue("@paraplaceid", rate.PlaceId);
            sqlCmd.Parameters.AddWithValue("@paradate", rate.Date);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
    }
}