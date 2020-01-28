using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Traversa2.BLL;

namespace Traversa2
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alertSuccess.Style.Add("color", "#D4EDDA");
        }

        

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            //string hashPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordTB.Text, "MD5");
            string name = nameTb.Text;
            string email = EmailTB.Text;
            string password = PasswordTB.Text;
            string cfmPasswod = cfmPasswordTB.Text;
            lblalert.Text = String.Empty;

            if (name == "")
            {
                lblalert.Text += "Name is required <br>";
                lblalert.ForeColor = Color.Red;
            }
            if( email == "")
            {
                lblalert.Text += "Email is required <br>";
                lblalert.ForeColor = Color.Red;
            }
            if (password == "")
            {
                lblalert.Text += "Password is required <br>";
                lblalert.ForeColor = Color.Red;
            }
            if (cfmPasswod == "")
            {
                lblalert.Text += "Confirm Password is required <br>";
                lblalert.ForeColor = Color.Red;
            }
            else
            {

                if (cfmPasswod != password)
                {
                    lblalert.Text = "Password does not match!";
                    lblalert.ForeColor = Color.Red;
                    alertDanger.Visible = true;
                }
                else
                {
                    Travellers user = new Travellers(name, password, email);
                    int result = user.AddNewUser();
                    if (result == 1)
                    {
                        lblSuccess.Text = "User created";
                        lblSuccess.ForeColor = Color.Green;
                        alertSuccess.Visible = true;

                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lblalert.Text = "Unable to create a user";
                        lblalert.ForeColor = Color.Red;
                        alertDanger.Visible = true;
                    }
                }
            }

        }
    }
}