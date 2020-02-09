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
        public List<Place> ratingList;
        public List<Place> regionList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Place pl = new Place();
                ratingList = pl.GetTop3Rating();

                DatalistRating.DataSource = ratingList;
                DatalistRating.DataBind();

                string reg = ddlRegion.SelectedItem.Value;
                regionList = pl.SelectByRegion(reg);
                DatalistRegion.DataSource = regionList;
                DatalistRegion.DataBind();
            }
        }

        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("Go"))
            {
                int placeid = Convert.ToInt32(e.CommandArgument);
                Session["PId"] = placeid.ToString();

                Response.Redirect("~/Views/Places/ViewOnePlace.aspx");
            }
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Place pl = new Place();
            string reg = ddlRegion.SelectedItem.Value;
            regionList = pl.SelectByRegion(reg);
            DatalistRegion.DataSource = regionList;
            DatalistRegion.DataBind();
        }

        protected void btnRec_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Places/RecommendPlace.aspx");
        }
    }
}