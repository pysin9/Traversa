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
            if (Session["Username"] != null)
            {
                UsernameLBL.Text = "Hi, " + Session["Username"];
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('You need to login first to access this page');window.location ='Login.aspx';",true);
            }
        }
    }
}