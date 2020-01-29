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
                    DataListPlaces.DataSource = null;
                    Place pl = new Place();
                    placeList = pl.GetAllPlaces();

                    DataListPlaces.DataSource = placeList;
                    DataListPlaces.DataBind();
                }
                else
                {

                }


            }
            else
            {
                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetAll();

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();

                if (Session["catid"] != null)
                {
                    //LabelNAme.Text = Session["Catname"].ToString();
                    DataListPlaces.DataSource = null;
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
            //int id;
            //Place pl = new Place();
            //placeList = pl.GetAllPlacesByCat(id);

            //DataListPlaces.DataSource = placeList;
            //DataListPlaces.DataBind();

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

                //string itemID = e.CommandArgument.ToString();
                //Label13.Text = itemID;

                //int id;
                //bool bIsConverted = int.TryParse(e.CommandArgument.ToString(), out id);
                int CatId = Convert.ToInt32(e.CommandArgument);
                Label13.Text = CatId.ToString();


                //Place pl = new Place();
                //placeList = pl.GetAllPlacesByCat(CatId);

                //DataListPlaces.DataSource = placeList;
                //DataListPlaces.DataBind();
            }
        }
    }
}