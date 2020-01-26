using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Users
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                password.Text = "";
                cfmpass.Text = "";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            string cfm = cfmpass.Text;

            int id = Convert.ToInt32(Session["UserID"]);
            TravellerProfile tv = new TravellerProfile();
            int rslt = tv.ChangePassword(id, pass);
            if (rslt == 1)
            {
                lblMsg.Text = "Successfully changed password!";
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMsg.Text = "An error occured while changing your password. Please try again!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            password.Text = "";
            cfmpass.Text = "";
        }
    }
}