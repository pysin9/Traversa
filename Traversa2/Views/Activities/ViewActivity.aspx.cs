using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Traversa2.Views.Activities
{
    public partial class ViewActivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int actid = 7;
                Activity ac = new Activity();
                ac = ac.retrieveOne(actid);
                name.Text = ac.AName;
                desc.Text = ac.ADesc;
                location.Text = ac.ALocation;
                image.ImageUrl = ac.ImagePath;

                people.Text = ac.APeople;
                price.Text = ac.APrice;

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            void AddToCart(string aid, string qty)
            {
                string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
                SqlConnection myConn = new SqlConnection(DBConnect);


                string sqlStmt = "INSERT INTO ShoppingCart (aidToBuy, qty) values (@aid, @qty)";

                int result = 0;    // Execute NonQuery return an integer value
                SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

                sqlCmd.Parameters.AddWithValue("@aid", aid);
                sqlCmd.Parameters.AddWithValue("@qty", qty);
                myConn.Open();
                result = sqlCmd.ExecuteNonQuery();

                myConn.Close();

            }
        }
    }
}
