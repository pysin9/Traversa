using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2
{
    public partial class navbarForAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                UsernameLBL.Text = "Hi, " + Session["Username"];
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You are not allow to access to this page');window.location ='/Views/Users/Login.aspx';", true);
            }
        }

        protected void LinkButtonAddPl_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/AddPlace.aspx");
        }

        protected void LinkButtonViewPl_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/ViewAllPlace.aspx");
        }

        protected void LinkButtonUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/Category.aspx");
        }

        protected void LinkButtonVCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/ViewAllCategory.aspx");
        }

        protected void LinkButtonCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/AddCategory.aspx");
        }

        protected void LinkButtonprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Users/Profile.aspx");
        }

        protected void LinkButtonlogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("Username");
            Session.Remove("Email");
            Session.Remove("UserID");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You have successfully log out');window.location ='/Views/Users/Login.aspx';", true);
        }
    }
}