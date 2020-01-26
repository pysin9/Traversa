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

            string sqlStmt = "INSERT INTO Rating (Rating, Review, UserId, PlaceId) VALUES (@paraRate, @paraReview, @paraUserid, @paraPlaceid)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraRate", rate.Rate);
            sqlCmd.Parameters.AddWithValue("@paraReview", rate.Review);
            sqlCmd.Parameters.AddWithValue("@paraUserid", rate.UserId);
            sqlCmd.Parameters.AddWithValue("@paraPlaceid", rate.PlaceId);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        //getall
        //delete one
    }
}