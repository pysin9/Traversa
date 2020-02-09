using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class Itinerary : System.Web.UI.Page
    {
        public List<CatergoriesID> categoryList;
        public List<Place> placeList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetAll();

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();

                if (Session["catid"] != null)
                {
                    int Catid = Convert.ToInt32(Session["catid"]);
                    Label13.Text = Catid.ToString();

                    Place pl = new Place();
                    placeList = pl.GetAllPlacesByCat(Catid);

                    DataListPlaces.DataSource = placeList;
                    DataListPlaces.DataBind();
                }
                else
                {

                }


            }

        }


        protected void LinkButtonPlaces_Click(object sender, EventArgs e)
        {
            Place pl = new Place();
            placeList = pl.GetAllPlaces();

            Session["PId"] = pl.PlId;

            Response.Redirect("ViewOnePlace.aspx");
        }

        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int CatId = Convert.ToInt32(e.CommandArgument);



                Place pl = new Place();
                placeList = pl.GetAllPlacesByCat(CatId);

                DataListPlaces.DataSource = placeList;
                DataListPlaces.DataBind();
            }
        }

        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            Place pl = new Place();
            placeList = pl.GetAllPlaces();

            DataListPlaces.DataSource = placeList;
            DataListPlaces.DataBind();
        }
		
		protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string substring = TextBoxSearch.Text;
            if (substring == "")
            {
                int Catid = Convert.ToInt32(Session["catid"]);
                Label13.Text = Catid.ToString();

                Place pl = new Place();
                placeList = pl.GetAllPlacesByCat(Catid);

                DataListPlaces.DataSource = placeList;
                DataListPlaces.DataBind();
            }
            else
            {
                Place pl = new Place();
                placeList = pl.GetBySearch(substring);

                DataListPlaces.DataSource = placeList;
                DataListPlaces.DataBind();
            }
        }
    }
}