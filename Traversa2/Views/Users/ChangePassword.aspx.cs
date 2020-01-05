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
            int userid = 1; //get userid
            string pass = Request.Form["password"];
            string cfm = Request.Form["cfmpass"];
            if (pass=="" || cfm=="")
            {
                lblMsg.Text = "Field empty!";
            }
            if (pass != cfm)
            {
                lblMsg.Text = "Passwords do not match!";
            }
            else
            {
                Travellers tv = new Travellers();
                tv.ChangePassword(userid, pass);
            }

        }
    }
}