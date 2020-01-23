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
    public class CatDAO
    {
        public int insertCat(CreateCategory cat)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Category (CatName, CatImage) VALUES (@paraName, @paraImage)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", cat.CatName);
            sqlCmd.Parameters.AddWithValue("@paraImage", cat.CatImage);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<CatergoriesID> GetEverything()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT CatID, CatName, CatImage FROM Category";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<CatergoriesID> recList = new List<CatergoriesID>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                recList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int catid = Convert.ToInt32(row["CatID"]);
                    string catname = Convert.ToString(row["CatName"]);
                    string catimage = Convert.ToString(row["CatImage"]);
                    CatergoriesID categories = new CatergoriesID(catid, catname, catimage);
                    recList.Add(categories);
                }
            }
            return recList;
        }
        public int DeleteCat(int catid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Category where CatID = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", catid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public CatergoriesID SelectByID(int CatID)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Category where CatID = @paraid";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraid", CatID);

            DataSet ds = new DataSet();
            da.Fill(ds);

            CatergoriesID user = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int Id = Convert.ToInt32(row["CatId"]);
                string name = row["CatName"].ToString();
                string image = row["CatImage"].ToString();


                user = new CatergoriesID(Id, name, image);


            }
            return user;
        }
    }
}