using System.Linq;
using System.Web;
using Traversa2.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Traversa2.DAL
{
    public class PlaceDAO
    {
        public int Insert(Place pl)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Place (PName, PDesc, Location) VALUES (@paraPName,@paraPDesc, @paraLocation)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPName", pl.PName);
            sqlCmd.Parameters.AddWithValue("@paraPDesc", pl.PDesc);
            sqlCmd.Parameters.AddWithValue("@paraPLocation", pl.PLocation);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int DeleteRec(int plid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Place where PlaceID = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", plid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        //(retrieve avgrating, image, cat)
        //public List<Places> GetAll()
        //{
        //    string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        //    SqlConnection myConn = new SqlConnection(DBConnect);

        //    String sqlstmt = "SELECT PlaceID, PName, PDesc, Location FROM Place";

        //    SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

        //    DataSet ds = new DataSet();
        //    da.Fill(ds);

        //    List<Places> recList = new List<Places>();

        //    int rec_cnt = ds.Tables[0].Rows.Count;
        //    if (rec_cnt == 0)
        //    {
        //        recList = null;
        //    }
        //    else
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            int plid = Convert.ToInt32(row["PlaceID"]);
        //            string pname = Convert.ToString(row["PName"]);
        //            string pdesc = Convert.ToString(row["PDesc"]);
        //            string location = Convert.ToString(row["Location"]);
        //            Places objRate = new Places(plid, pname, pdesc, location);
        //            recList.Add(objRate);
        //        }
        //    }
        //    return recList;
        //}
    }
}