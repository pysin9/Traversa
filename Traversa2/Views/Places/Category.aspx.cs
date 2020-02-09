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

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();



            }


        }



        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Go"))
            {
                int CatId = Convert.ToInt32(e.CommandArgument);
                Session["catid"] = CatId.ToString();

                Response.Redirect("Itinerary.aspx");
            }
        }
		
		protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string substring = TextBoxSearch.Text;

            if (substring == "")
            {
                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetAll();

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();
            }
            else
            {
                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetBySearch(substring);

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();
            }
        }
    }
}