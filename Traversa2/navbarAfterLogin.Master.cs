using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2
{
    public partial class navbarAfterLogin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButtonHost.Visible = false;
            if (Session["Username"] != null)
            {
                int ishot = Convert.ToInt32(Session["isHost"]);
                UsernameLBL.Text = "Hi, " + Session["Username"];
                if (ishot == 1)
                {
                    LinkButtonHost.Visible = true;
                }
                else
                {
                    LinkButtonHost.Visible = false;
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You need to login first to access this page');window.location ='/Views/Users/Login.aspx';", true);
            }
        }

        protected void LinkButtonProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Users/Profile.aspx");
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("Username");
            Session.Remove("Email");
            Session.Remove("UserID");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You have successfully log out');window.location ='/Views/Users/Login.aspx';", true);
        }

        protected void LinkButtonIt_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/MyItinenary/Viewitinerary.aspx");
        }

        protected void LinkButtonHost_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Activities/HostActivity.aspx");
        }
    }
}