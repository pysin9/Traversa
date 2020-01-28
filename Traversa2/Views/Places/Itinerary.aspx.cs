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
                    //LabelNAme.Text = Session["Catname"].ToString();
                    Place pl = new Place();
                    placeList = pl.GetAllPlaces();

                    DataListPlaces.DataSource = placeList;
                    DataListPlaces.DataBind();
                }
                else
                {

                }


            }
        }

        protected void LinkButtonCat_Click(object sender, EventArgs e)
        {
            Place pl = new Place();
            placeList = pl.GetAllPlaces();

            DataListPlaces.DataSource = placeList;
            DataListPlaces.DataBind();
        }
    }
}