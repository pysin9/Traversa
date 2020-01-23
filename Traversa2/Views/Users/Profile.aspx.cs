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
            if (IsPostBack==false)
            {
                if (Session["UserID"] !=null) // means not logged in, but masterpage page_load will handle and kick user back to login
                {
                    int id = Convert.ToInt32(Session["UserID"]);
                    TravellerProfile tp = new TravellerProfile();
                    tp = tp.RetrieveOne(id);
                    if (tp!=null)
                    {
                        username.Text = tp.Name;
                        uemail.Text = tp.Email;
                        lang.SelectedValue = tp.Language.ToString();
                        travelstyle.SelectedValue = tp.Style.ToString();
                        foodpref.SelectedValue = tp.FoodPref.ToString();
                        travelstyle.SelectedValue = tp.Style.ToString();
                    }
                    else
                    {

                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["UserID"]);
            string Uname = username.Text;
            string Email = uemail.Text;
            string FoodPref = foodpref.SelectedItem.ToString();
            string Language = lang.SelectedItem.ToString();
            string style = travelstyle.SelectedItem.ToString();

            TravellerProfile tp = new TravellerProfile(id, Uname, Email, FoodPref, Language, style);
            int rslt = tp.UpdateProifle();

            if (rslt == 1)
            {
                lblMsg.Text = "Update successful!";
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMsg.Text = "An error occured while updating your profile. Please try again";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }
}