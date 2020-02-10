using Traversa2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traversa2.Views.FAQ
{
    public partial class FAQAdmin : System.Web.UI.Page
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

            GridView1.Visible = true;
            GridView1.DataSource = fList;
            GridView1.DataBind();
        }
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("FaqAddForm.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            Session["SSFaqid"] = row.Cells[0].Text;
            Session["SSqns"] = row.Cells[1].Text;
            Session["SSans"] = row.Cells[2].Text;

            Response.Redirect("FaqUpdate.aspx");
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("FaqAddForm.aspx");
        }
    }
}