using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class RecommendPlace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==true)
            {
                lblerror.Text = "";
            }
            else
            {

            }
        }

        protected void btnRec_Click(object sender, EventArgs e)
        {
            string name = RName.Text;
            string reason = Request.Form["RReason"];
            int price = Convert.ToInt32(rdPrice.SelectedValue);
            int quality = Convert.ToInt32(rdOverall.SelectedValue);

            if (reason =="" || name =="")
            {
                lblerror.Text = "Please fill up all fields!";
                lblerror.ForeColor = System.Drawing.Color.Red;
            }
            if (price == 0)
            {
                lblerror.Text = "Price rating has not been selected";
            }
            if (quality == 0)
            {
                lblerror.Text = "Overall rating has not been selected";
            }
            else
            {
                Recommendations rec = new Recommendations(name, reason, price, quality);
                int rslt = rec.AddRecommendation();
                lblerror.Text = rslt.ToString();
                if (rslt == 1)
                {
                    lblerror.Text = "Recommendation has been received, Thank you!";
                    lblerror.ForeColor = System.Drawing.Color.Green;
                    lblerror.Text = "";
                    RName.Text = "";

                }
                else
                {
                    lblerror.Text = "An error occured while processing your recommendation";
                    lblerror.ForeColor = System.Drawing.Color.Red;
                }
                
            }

            
        }
    }
}