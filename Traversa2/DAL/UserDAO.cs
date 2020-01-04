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
    public class UserDAO
    {
        public int Insert(Users u)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Travellers (Username,Password,Email) " +
                "VALUES (@paraName,@paraPassword, @paraEmail)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraName", u.Name);
            sqlCmd.Parameters.AddWithValue("@paraPassword", u.Password);
            sqlCmd.Parameters.AddWithValue("@paraEmail", u.Email);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
    }
}