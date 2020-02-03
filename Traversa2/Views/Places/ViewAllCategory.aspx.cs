using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;
using System.Drawing;

namespace Traversa2.Views.Places
{
    public partial class EditCategory : System.Web.UI.Page
    {
        public List<CatergoriesID> categoryList;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            CatergoriesID cat = new CatergoriesID();
            categoryList = cat.GetAll();

            GridViewCat.DataSource = categoryList;
            GridViewCat.DataBind();
        }



        protected void GridViewCat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridViewCat.DataKeys[e.RowIndex].Value);



            CatergoriesID rec = new CatergoriesID();
            rec.DeleteSelected(id);
            LabelMessage.Text = "Successfully deleted!";
            LabelMessage.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        

        protected void GridViewCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewCat.SelectedRow;
            Session["Catid"] = row.Cells[0].Text;
            Response.Redirect("EditCategory.aspx");
        }
    }
}