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

        }

        protected void LinkButtonAddPl_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/AddPlace.aspx");
        }

        protected void LinkButtonViewPl_Click(object sender, EventArgs e)
        {
            Response.Redirect("Views/Places/ViewAllPlace.aspx");
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
            Response.Redirect("Profile.aspx");
        }

        protected void LinkButtonlogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("Username");
            Session.Remove("Email");
            Session.Remove("UserID");
            Response.Redirect("/Views/Users/Login.aspx");
        }
    }
}