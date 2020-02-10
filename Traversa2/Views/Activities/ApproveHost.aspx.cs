using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Traversa2.Views.Activities
{
    public partial class ApproveHost : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["Email"]) == HEmail.Text)
            {
                if (HostRequired.Checked == true)
                {
                    int id = Convert.ToInt32(Session["UserID"]);
                    string Email = HEmail.Text;
                    //string Desc = HDesc.Text;
                    //string Reason = HReasons.Text;

                    //TravellerProfile tp = new TravellerProfile(id, Email, Desc, Reason);
                    TravellerProfile tp = new TravellerProfile(Email);
                    int result = tp.HostApproval();

                    if (result == 1)
                    {
                        LblMsg.Text = "Successfully signed up as a Host!";
                        LblMsg.ForeColor = System.Drawing.Color.Green;
                        Session["isHost"] = tp.isHost.ToString();

                        HEmail.Text = "";
                        //HDesc.Text = "";
                        //HReasons.Text = "";

                    }
                    else
                    {
                        LblMsg.Text = "An error occured. Please try again";
                        LblMsg.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    LblMsg.Text = "Please tick the Accept Host Terms checkbox!";
                    LblMsg.ForeColor = System.Drawing.Color.Red;
                }

            }

            else
            {
                LblMsg.Text = "Email entered is not the same as your user email!";
                LblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}