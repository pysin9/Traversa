﻿using System;
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
            Response.Redirect("Homepage.aspx");
        }

        protected void LinkButtonMap_Click(object sender, EventArgs e)
        {
            Response.Redirect("Map.aspx");
        }

        protected void LinkButtonItinerary_Click(object sender, EventArgs e)
        {
            Response.Redirect("Category.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Users/Login.aspx");
        }
    }
}