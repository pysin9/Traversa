using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class Category : System.Web.UI.Page
    {
        public List<CatergoriesID> categoryList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetAll();

                Session["catid"] = cat.CatId;
                Session["Catname"] = cat.CatName;

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();



            }


        }

        protected void LinkButtonCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Itinerary.aspx");
        }
    }
}