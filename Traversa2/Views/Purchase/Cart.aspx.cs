using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2.Views.Purchase
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) // means displaying the page for first time
            {
                System.Media.SystemSounds.Beep.Play();
                DisplayGrid();
                DisplayShoppingCart();

            }
        }

        void DisplayGrid()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Activities";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);


            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        void DisplayShoppingCart()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select aid,aname,aprice,qty from ShoppingCart join Activities on aid=aidToBuy";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);


            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        void RemoveFromCart(string aid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "delete from ShoppingCart WHERE aidToBuy=@aid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@aid", aid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();
            DisplayShoppingCart();
            DisplayGrid();
        }

        void AddToCart(string aid, string qty)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "INSERT INTO ShoppingCart (aidToBuy, qty)values(@aid,@qty)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@aid", aid);
            sqlCmd.Parameters.AddWithValue("@qty", qty);
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();
            DisplayShoppingCart();
            DisplayGrid();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = 0;
            GridViewRow row;
            GridView grid = sender as GridView;

            index = Convert.ToInt32(e.CommandArgument);
            row = grid.Rows[index];

            if (e.CommandName == "AddToCart")
            {
                // getting qty
                TextBox temptb = (TextBox)row.Cells[3].FindControl("tbQtyToAdd");
                string qty = temptb.Text;
                string aid = row.Cells[0].Text;
                AddToCart(aid, qty);
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = 0;
            GridViewRow row;
            GridView grid = sender as GridView;

            index = Convert.ToInt32(e.CommandArgument);
            row = grid.Rows[index];

            if (e.CommandName == "RemoveFromCart")
            {

                string aid = row.Cells[1].Text;
                RemoveFromCart(aid);
            }
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}