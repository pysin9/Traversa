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
    public class RecDAO
    {
        public int Insert(Recommendations rec)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Recommendation (RName, RReason, Price, Quality) VALUES (@paraRName,@paraRReason, @paraPrice, @paraQuality)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraRName", rec.RName);
            sqlCmd.Parameters.AddWithValue("@paraRReason", rec.RReason);
            sqlCmd.Parameters.AddWithValue("@paraPrice", rec.priceRate);
            sqlCmd.Parameters.AddWithValue("@paraQuality", rec.qualityRate);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        public int DeleteRec(int recid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Recommendation where RecID = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", recid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        //SelectAllRecommendation
        public List<Recommendations> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Recommendation";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Recommendations> recList = new List<Recommendations>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int recid = Convert.ToInt32(row["RecID"]);
                    string rname = Convert.ToString(row["RName"]);
                    string rreason = Convert.ToString(row["RReason"]);
                    int price = Convert.ToInt32(row["Price"]);
                    int quality = Convert.ToInt32(row["Quality"]);
                    Recommendations objRate = new Recommendations(rname, rreason, recid, price, quality);
                    recList.Add(objRate);
                }
            }
            return recList;
        }
    }
}