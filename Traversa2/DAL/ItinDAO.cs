using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Traversa2.BLL;

namespace Traversa2.DAL
{
    public class ItinDAO
    {

        public int Insert(Itinerary it)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Itinerary (PlaceId, IName, UserId) VALUES (@paraPlace, @paraName, @paraUser)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPlace", it.PlId);
            sqlCmd.Parameters.AddWithValue("@paraName", it.IName);
            //sqlCmd.Parameters.AddWithValue("@paraTime", it.selectTime);
            //sqlCmd.Parameters.AddWithValue("@paraDate", it.selectDate);
            sqlCmd.Parameters.AddWithValue("@paraUser", it.UserId);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int DeleteIT(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Itinerary where ItinId = @paraid";

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