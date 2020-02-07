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
    public class ActivityDAO
    {
        public int Insert(Activity ac)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Activity (ActName, ActDesc, Location, CatId, Image, ActPpl, ActPrice, ActProvided, ActToBring) VALUES (@paraAName,@paraADesc, @paraALocation, @paraCatid, @paraimage," +
                " @paraAPeople, @paraAPrice, @paraAProvided, @paraABring)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraAName", ac.AName);
            sqlCmd.Parameters.AddWithValue("@paraADesc", ac.ADesc);
            sqlCmd.Parameters.AddWithValue("@paraALocation", ac.ALocation);
            sqlCmd.Parameters.AddWithValue("@paraCatid", ac.CatId);
            sqlCmd.Parameters.AddWithValue("@paraimage", ac.ImagePath);
            sqlCmd.Parameters.AddWithValue("@paraAPeople", ac.APeople);
            sqlCmd.Parameters.AddWithValue("@paraAPrice", ac.APrice);
            sqlCmd.Parameters.AddWithValue("@paraAProvided", ac.AProvided);
            sqlCmd.Parameters.AddWithValue("@paraABring", ac.ABring);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int DeleteActivity(int acid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Delete Activity where ActId = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraId", acid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public List<Activity> GetAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Activity";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Activity> acList = new List<Activity>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                acList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int acid = Convert.ToInt32(row["ActId"]);
                    string aname = row["ActName"].ToString();
                    string adesc = row["ActDesc"].ToString();
                    string aloca = row["Location"].ToString();
                    string image = row["Image"].ToString();
                    int catid = Convert.ToInt32(row["CatId"]);
                    string appl = row["ActPpl"].ToString();
                    string acost = row["ActPrice"].ToString();
                    string apvditem = row["ActProvided"].ToString();
                    string abringitem = row["ActToBring"].ToString();

                    Activity objRate = new Activity(acid, aname, adesc, aloca, catid, image, appl, acost, apvditem, abringitem);
                    acList.Add(objRate);
                }
            }
            return acList;
        }

        public Activity getOne(int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From Activity where ActId = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Activity activity = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string aname = row["ActName"].ToString();
                string adesc = row["ActDesc"].ToString();
                string location = row["Location"].ToString();
                string image = row["Image"].ToString();
                int catid = Convert.ToInt32(row["CatId"].ToString());
                string appl = row["ActPpl"].ToString();
                string acost = row["ActPrice"].ToString();
                string apvditem = row["ActProvided"].ToString();
                string abringitem = row["ActToBring"].ToString();


                activity = new Activity(aname, adesc, location, catid, image, appl, acost, apvditem, abringitem);


            }
            return activity;
        }

        public int UpdateActivity(Activity ac, int id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Activity SET ActName = @paraaname, ActDesc = @paraadesc, Location = @paraloca, CatId = @paracatid, Image = @paraimage, " +
                "ActPpl = @paraappl, ActPrice = @paraacost, ActProvided = @paraapvditem, ActToBring = @paraabringitem where ActId =  @paraacid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);


            sqlCmd = new SqlCommand(sqlStmt.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("@paraacid", id);
            sqlCmd.Parameters.AddWithValue("@paraaname", ac.AName);
            sqlCmd.Parameters.AddWithValue("@paraadesc", ac.ADesc);
            sqlCmd.Parameters.AddWithValue("@paraloca", ac.ALocation);
            sqlCmd.Parameters.AddWithValue("@paracatid", ac.CatId);
            sqlCmd.Parameters.AddWithValue("@paraimage", ac.ImagePath);
            sqlCmd.Parameters.AddWithValue("@paraappl", ac.APeople);
            sqlCmd.Parameters.AddWithValue("@paraacost", ac.APrice);
            sqlCmd.Parameters.AddWithValue("@parapvditem", ac.AProvided);
            sqlCmd.Parameters.AddWithValue("@paraabringitem", ac.ABring);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }


        public List<Activity> SelectByCat(int catId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Activity where CatId = @paraID ";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraID", catId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<Activity> acList = new List<Activity>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                acList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int acid = Convert.ToInt32(row["ActId"]);
                    string aname = row["ActName"].ToString();
                    string adesc = row["ActDesc"].ToString();
                    string aloca = row["Location"].ToString();
                    string image = row["Image"].ToString();
                    int catid = Convert.ToInt32(row["CatId"]);
                    string apeople = row["ActPpl"].ToString();
                    string aprice = row["ActPrice"].ToString();
                    string aprovided = row["ActProvided"].ToString();
                    string abring = row["ActToBring"].ToString();

                    Activity objRate = new Activity(acid, aname, adesc, aloca, catid, image, apeople, aprice, aprovided, abring);
                    acList.Add(objRate);
                }
            }
            return acList;
        }
    }
}