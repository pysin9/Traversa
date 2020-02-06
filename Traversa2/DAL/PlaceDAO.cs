using System.Linq;
using System.Web;
using Traversa2.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Traversa2.DAL
{
    public class PlaceDAO
    {
        public int Insert(Place pl)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Place (PName, PDesc, Location, CatId, Image, Region) VALUES (@paraPName,@paraPDesc, @paraPLocation, @paraCatid, @paraimage, @parareg)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraPName", pl.PName);
            sqlCmd.Parameters.AddWithValue("@paraPDesc", pl.PDesc);
            sqlCmd.Parameters.AddWithValue("@paraPLocation", pl.PLocation);
            sqlCmd.Parameters.AddWithValue("@paraCatid", pl.CatId);
            sqlCmd.Parameters.AddWithValue("@paraimage", pl.ImagePath);
            sqlCmd.Parameters.AddWithValue("@parareg", pl.Region);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int DeletePlace(int plid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Place where PlaceId = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", plid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<Place> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT PName, PDesc, Location, Image, PlaceId, AvgRating, Place.CatId, CatName, Region FROM Place INNER JOIN Category ON Place.CatId = Category.CatId";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Place> plList = new List<Place>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                plList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string catname = row["CatName"].ToString();
                    int plid = Convert.ToInt32(row["PlaceId"]);
                    string pname = row["PName"].ToString();
                    string pdesc = row["PDesc"].ToString();
                    string ploca = row["Location"].ToString();
                    string image = row["Image"].ToString();
                    double avgrate = Convert.ToDouble(row["AvgRating"]);
                    int catid = Convert.ToInt32(row["CatId"]);
                    string reg = Convert.ToString(row["Region"]);

                    Place objRate = new Place(plid, pname, pdesc, ploca, catid, image, avgrate, catname, reg);
                    plList.Add(objRate);
                }
            }
            return plList;
        }

        public Place getOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT PName, PDesc, Location, Image, PlaceId, AvgRating, Place.CatId, CatName, Region FROM Place INNER JOIN Category ON Place.CatId = Category.CatId where PlaceId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Place place = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string pname = row["PName"].ToString();
                string pdesc = row["PDesc"].ToString();
                string location = row["Location"].ToString();
                string image = row["Image"].ToString();
                int catid = Convert.ToInt32(row["CatId"].ToString());
                double avgrating = Convert.ToDouble(row["AvgRating"]);
                int plid = Convert.ToInt32(row["PlaceId"]);
                string catname = Convert.ToString(row["CatName"]);
                string reg = Convert.ToString(row["Region"]);

                place = new Place(plid, pname, pdesc, location, catid, image, avgrating, catname, reg);


            }
            return place;
        }

        public int UpdatePlace(Place pl, int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Place SET PName = @parapname, PDesc = @parapdesc, Location = @paraloca, CatId = @paracatid, Image = @paraimage, Region = @parareg where PlaceId =  @paraplid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraplid", id);
            sqlCmd.Parameters.AddWithValue("@parapname", pl.PName);
            sqlCmd.Parameters.AddWithValue("@parapdesc", pl.PDesc);
            sqlCmd.Parameters.AddWithValue("@paraloca", pl.PLocation);
            sqlCmd.Parameters.AddWithValue("@paracatid", pl.CatId);
            sqlCmd.Parameters.AddWithValue("@paraimage", pl.ImagePath);
            sqlCmd.Parameters.AddWithValue("@parareg", pl.Region);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<Place> SelectByCat(int catId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Place where CatId = @paraID ";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", catId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Place> plList = new List<Place>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                plList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int plid = Convert.ToInt32(row["PlaceId"]);
                    string pname = row["PName"].ToString();
                    string pdesc = row["PDesc"].ToString();
                    string ploca = row["Location"].ToString();
                    string image = row["Image"].ToString();
                    double avgrate = Convert.ToDouble(row["AvgRating"]);
                    int catid = Convert.ToInt32(row["CatId"]);
                    string reg = Convert.ToString(row["Region"]);

                    Place objRate = new Place(plid, pname, pdesc, ploca, catid, image, avgrate, reg);
                    plList.Add(objRate);
                }
            }
            return plList;
        }

        public Place GetAvgRating(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT ROUND(AVG(Rating),2) AS avgrate From Rating where PlaceId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Place place = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                double avgrating = Convert.ToDouble(row["avgrate"]);

                place = new Place(avgrating);
            }
            return place;
        }

        public int UpdateRating(int id, double avgrating)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Place SET AvgRating = @paraavgrating where PlaceId =  @paraplid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraplid", id);
            sqlCmd.Parameters.AddWithValue("@paraavgrating", avgrating);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
    }
}