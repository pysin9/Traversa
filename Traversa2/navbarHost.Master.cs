using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2
{
    public partial class navbarHost : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                UsernameLBL.Text = "Hi, " + Session["Username"];
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You need to login first to access this page');window.location ='/Views/Users/Login.aspx';", true);
            }
        }

      

        protected void LinkButtonPro_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Users/Profile.aspx");
        }

        protected void LinkButtonit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/MyItinenary/Viewitinerary.aspx");
        }

        protected void LinkButtonLog_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("Username");
            Session.Remove("Email");
            Session.Remove("UserID");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You have successfully log out');window.location ='/Views/Users/Login.aspx';", true);
        }
    }
}