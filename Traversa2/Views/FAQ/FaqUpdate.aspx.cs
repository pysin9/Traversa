using Traversa2.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2
{
    public partial class FaqUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TbFaqid.Text = (string)Session["SSId"];
                Tbqns.Text = (string)Session["SSQuestion"];
                Tbans.Text = (string)Session["SSAnswer"];

            }
        }



        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FAQ.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                Faq f = new Faq(TbFaqid.Text, Tbqns.Text, Tbans.Text);
                int result = f.UpdateFaq();
                if (result == 1)
                {
                    LblMsg.Text = "Record updated successfully!";
                    LblMsg.ForeColor = Color.Green;
                }
                else
                {
                    LblMsg.Text = "Error in adding record!";
                    LblMsg.ForeColor = Color.Red;
                }
            }
        }
        private bool ValidateInput()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (String.IsNullOrEmpty(Tbqns.Text))
            {
                LblMsg.Text += "Question is required!" + "<br/>";
            }



            if (String.IsNullOrEmpty(LblMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}