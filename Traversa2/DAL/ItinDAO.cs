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

        public List<Itinerary> GetAll(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT ItinId, IName, Itinerary.PlaceId, UserId, PName, Image, AvgRating FROM Itinerary INNER JOIN Place ON Itinerary.PlaceId = Place.PlaceId where UserId = @paraid";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraid", id);

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
                    string iname = row["IName"].ToString();
                    int plid = Convert.ToInt32(row["PlaceId"]);
                    string pname = row["PName"].ToString();
                    string image = row["Image"].ToString();
                    double avgrate = Convert.ToDouble(row["AvgRating"]);
                    int itinid = Convert.ToInt32(row["ItinId"]);
                    int userid = Convert.ToInt32(row["UserId"]);

                    Itinerary objRate = new Itinerary(itinid, iname, plid, userid, pname, image, avgrate);
                    plList.Add(objRate);
                }
            }
            return plList;
        }

        public Itinerary SelectByuserid(int ID)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Itinerary where UserId = @paraID";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", ID);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Itinerary user = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int id = Convert.ToInt32(row["ItinId"]);
                string iname = row["IName"].ToString();
                int pid = Convert.ToInt32(row["PlaceId"]);
                int uid = Convert.ToInt32(row["UserId"]);



                user = new Itinerary(id, iname, pid, uid);


            }
            return user;
        }

    }
}