using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = "test@gmail.com"; //retrieve using session
            Travellers tv = new Travellers();
            tv.GetTDbyEmail(email);

            username.Text = tv.Name;
            uemail.Text = tv.Email;
        }
    }
}