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





            string sqlStmt = "INSERT INTO Itinerary (IName, UserId) VALUES (@paraName, @paraUser)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            //sqlCmd.Parameters.AddWithValue("@paraPlace", it.PlId);
            sqlCmd.Parameters.AddWithValue("@paraName", it.IName);
            //sqlCmd.Parameters.AddWithValue("@paraTime", it.selectTime);
            //sqlCmd.Parameters.AddWithValue("@paraDate", it.selectDate);
            sqlCmd.Parameters.AddWithValue("@paraUser", it.UserId);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int InsertPlId(Itinerary it, int id, string name)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Itinerary SET PlaceId = @paraPlace WHERE UserId = @paraid  AND IName = @paraname";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPlace", it.PlId);
            sqlCmd.Parameters.AddWithValue("@paraid", it.UserId);
            sqlCmd.Parameters.AddWithValue("@paraname", it.IName);
            //sqlCmd.Parameters.AddWithValue("@paraTime", it.selectTime);
            //sqlCmd.Parameters.AddWithValue("@paraDate", it.selectDate);


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

        public List<Itinerary> Getall()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT DISTINCT ItinId, IName, UserId FROM Itinerary";

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
                    //string time = row["selectTime"].ToString();
                    //string date = row["selectDate"].ToString();
                    int userid = Convert.ToInt32(row["UserId"]);
                    //int pid = Convert.ToInt32(row["PlaceId"]);

                    Itinerary objRate = new Itinerary(Iid, name, userid);
                    plList.Add(objRate);
                }
            }
            return plList;
        }

        public Itinerary getOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT DISTINCT IName From Itinerary where ItinId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Itinerary ca = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string name = row["IName"].ToString();

                ca = new Itinerary(name);


            }
            return ca;
        }

        public List<Itinerary> GetEverything()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT ItinId, PlaceId, IName, UserId FROM Itinerary INNER JOIN Place ON Itinerary.PlaceId = Place.PlaceId";

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
                    string iname = row["IName"].ToString();
                    int plid = Convert.ToInt32(row["PlaceId"]);
                    string pname = row["PName"].ToString();
                    int placeid = Convert.ToInt32(row["PlaceId"]);
                    string image = row["Image"].ToString();
                    double avgrate = Convert.ToDouble(row["AvgRating"]);
                    int userid = Convert.ToInt32(row["UserId"]);
                    int iId = Convert.ToInt32(row["ItinId"]);


                    Itinerary objRate = new Itinerary(iId, iname, placeid, userid, plid, pname, image, avgrate);
                    plList.Add(objRate);
                }
            }
            return plList;
        }




    }
}