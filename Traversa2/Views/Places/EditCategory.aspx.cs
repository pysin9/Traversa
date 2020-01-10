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
        public List<CreateCategory> categoryList;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
           CreateCategory cat = new CreateCategory();
           categoryList = cat.GetAll();

           GridViewCat.DataSource = categoryList;
           GridViewCat.DataBind();
        }

       

        protected void GridViewCat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridViewCat.DataKeys[e.RowIndex].Value);


        
            CreateCategory rec = new CreateCategory();
            rec.DeleteSelected(id);
            LabelMessage.Text = "Successfully deleted!";
            LabelMessage.ForeColor = System.Drawing.Color.Green;
            BindData();
        }
    }
}