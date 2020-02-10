using Traversa2.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2.Views.FAQ
{
    public partial class FaqAddForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateInput()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (Tbfaqid.Text == "")
            {
                LblMsg.Text += "FaqId is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbQuestion.Text))
            {
                LblMsg.Text += "Question is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbAnswer.Text))
            {
                LblMsg.Text += "Answer is required!" + "<br/>";
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

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Faq f = new Faq();

            if (f.GetFaqById(Tbfaqid.Text) != null)
            {
                LblMsg.Text = "Record already exists!";
                LblMsg.ForeColor = Color.Red;
            }
            else
            {
                if (ValidateInput())
                {


                    f = new Faq(Tbfaqid.Text, TbQuestion.Text, TbAnswer.Text);
                    int result = f.AddFaq();
                    if (result == 1)
                    {
                        LblMsg.Text = "Record added successfully!";
                        LblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        LblMsg.Text = "Error in adding record! Inform System Administrator!";
                        LblMsg.ForeColor = Color.Red;
                    }
                }
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FAQ.aspx");
        }
    }
}