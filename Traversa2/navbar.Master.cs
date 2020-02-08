using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2
{
    public partial class navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtonhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Home/Home.aspx");
        }

        protected void LinkButtonMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Map/Map.aspx");
        }

        protected void LinkButtonItinerary_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Places/Category.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Users/Login.aspx");
        }

        protected void LinkButtonEvent_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Activities/ActivityList.aspx");
        }
    }
}