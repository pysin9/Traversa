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
    public partial class Checkout : System.Web.UI.Page
    {
        double totalAmt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) // means displaying the page for first time
            {
                System.Media.SystemSounds.Beep.Play();
                DisplayCheckOut();

            }
        }

        void DisplayCheckOut()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select aid,aname,aprice,qty from ShoppingCart join Activities on aid=aidToBuy";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);


            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string amtS = e.Row.Cells[2].Text;
                totalAmt += Convert.ToDouble(amtS);
                lbl_TotalAmt.Text = totalAmt.ToString();

            }

        }
    }
}