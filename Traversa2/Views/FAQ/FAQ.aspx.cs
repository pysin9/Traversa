using Traversa2.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI.WebControls;


namespace Traversa2
{
    public partial class FaqForm : System.Web.UI.Page
    {
        List<Faq> fList;

        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            Faq f = new Faq();
            fList = f.GetAllFaq();

            // using gridview to bind to the list of employee objects
            GvFaq.Visible = true;
            GvFaq.DataSource = fList;
            GvFaq.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("FaqAddForm.aspx");
        }

        /*protected void GvFaq_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvFaq.SelectedRow;
            Session["SSFaqid"] = row.Cells[0].Text;
            Session["SSqns"] = row.Cells[1].Text;
            Session["SSans"] = row.Cells[2].Text;

            Response.Redirect("FaqAddForm.aspx");

        } */

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("View/FAQ/FaqAddForm.aspx");
        }
    }
}