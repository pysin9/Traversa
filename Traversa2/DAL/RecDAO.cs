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
        public int Insert(Recommendation rec)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Recommendation (RName, RReason) VALUES (@paraRName,@paraRReason)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraRName", rec.RName);
            sqlCmd.Parameters.AddWithValue("@paraRReason", rec.RReason);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        public int DeleteRec(int recid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Recommendation where RecID = @id";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", recid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        //SelectAllRecommendation
        public List<Recommendation> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT RecID, RName, RReason FROM Recommendation";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Recommendation> recList = new List<Recommendation>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string recid = Convert.ToString(row["RecID"]);
                    string rname = Convert.ToString(row["RName"]);
                    string rreason = Convert.ToString(row["RReason"]);
                    Recommendation objRate = new Recommendation(rname, rreason);
                    recList.Add(objRate);
                }
            }
            return recList;
        }
    }
}