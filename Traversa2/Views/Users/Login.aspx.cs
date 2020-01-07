﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;
using System.Drawing;

namespace Traversa2.Views.Users
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = emailTB.Text;
            string password = passwordTB.Text;
           
            lblError.Text = String.Empty;

            
            if (email == "")
            {
                lblError.Text += "Email is required <br>";
                lblError.ForeColor = Color.Red;
            }
            if (password == "")
            {
                lblError.Text += "Password is required <br>";
                lblError.ForeColor = Color.Red;
            }
            
            else
            {
                Travellers user = new Travellers();
                user = user.GetbyEmail(emailTB.Text);
                if (user != null)
                {

                    Session["Username"] = user.Name.ToString();
                    Session["Email"] = user.Email.ToString();

                    lblsuccess.Text = "Login Success";
                    lblsuccess.ForeColor = Color.Green;
                    
                }
                else
                {
                    lblError.Text = "Incorrect Email/Password";
                    lblError.ForeColor = Color.Red;
                }
                
            }

        }
    }
}