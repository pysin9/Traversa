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

            string sqlStmt = "INSERT INTO Itinerary ( PlaceId, IName, selectTime, selectDate, UserId) VALUES (@paraPlace,@paraName, @paraTime, @paraDate, @paraUser)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPlace", it.PlId);
            sqlCmd.Parameters.AddWithValue("@paraName", it.IName);
            sqlCmd.Parameters.AddWithValue("@paraTime", it.selectTime);
            sqlCmd.Parameters.AddWithValue("@paraDate", it.selectDate);
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

        public List<Itinerary> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Itinerary";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Itinerary> plList = new List<Itinerary>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                plList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int Iid = Convert.ToInt32(row["ItinId"]);
                    string name = row["IName"].ToString();
                    DateTime time = Convert.ToDateTime(row["selectTime"]);
                    DateTime date = Convert.ToDateTime(row["selectDate"]);
                    int userid = Convert.ToInt32(row["UserId"]);
                    int pid = Convert.ToInt32(row["PlaceId"]);

                    Itinerary objRate = new Itinerary(Iid,pid,name,time,date,userid);
                    plList.Add(objRate);
                }
            }
            return plList;
        }

        
    }
}