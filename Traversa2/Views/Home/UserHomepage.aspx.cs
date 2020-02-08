using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Home
{
    public partial class UserHomepage : System.Web.UI.Page
    {
        public List<Place> categoryList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Place pl = new Place();
                categoryList = pl.GetTop3Rating();

                DatalistRating.DataSource = categoryList;
                DatalistRating.DataBind();
            }
        }

        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Go"))
            {
                int placeid = Convert.ToInt32(e.CommandArgument);
                Session["PlaceId"] = placeid.ToString();

                Response.Redirect("~/Views/Places/ViewOnePlace.aspx");
            }
        }
    }
}