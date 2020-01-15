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
            TravellerProfile tp = new TravellerProfile();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string Uname = username.Text;
            string Email = uemail.Text;
            string FoodPref = foodpref.SelectedItem.ToString();
            string Language = language.Text;

            //TravellerProfile tp = new TravellerProfile(Uname, Email, FoodPref, Language);
            //tp.UpdateProifle();
            
        }
    }
}