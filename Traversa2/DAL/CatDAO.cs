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

        public CatergoriesID getOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Category where CatId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            CatergoriesID ca = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string name= row["CatName"].ToString();
                string image = row["CatImage"].ToString();
                
                int catid = Convert.ToInt32(row["CatId"].ToString());


                ca = new CatergoriesID(catid,name, image);


            }
            return ca;
        }

        public List<CatergoriesID> SelectOne(int catId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Category where CatId = @paraID ";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", catId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<CatergoriesID> plList = new List<CatergoriesID>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                plList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                   
                    string name = row["CatName"].ToString();
                    string image = row["CatImage"].ToString();
                    int catid = Convert.ToInt32(row["CatId"]);

                    CatergoriesID cat = new CatergoriesID(catId, name, image); 
                    plList.Add(cat);
                }
            }
            return plList;
        }

        public int UpdateCat(CatergoriesID ca, int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Category SET CatName = @parapname, CatImage = @paraimage WHERE CatId =  @paraplid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraplid", id);
            sqlCmd.Parameters.AddWithValue("@parapname", ca.CatName);
            sqlCmd.Parameters.AddWithValue("@paraimage", ca.CatImage);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<CatergoriesID> SearchFor(string substring)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Category where CatName LIKE @query";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@query", "%" + substring + "%");

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<CatergoriesID> plList = new List<CatergoriesID>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                plList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int catid = Convert.ToInt32(row["CatId"]);
                    string catname = row["CatName"].ToString();
                    string catimage = row["CatImage"].ToString();

                    CatergoriesID objRate = new CatergoriesID(catid, catname, catimage);
                    plList.Add(objRate);
                }
            }
            return plList;
        }
    }
}