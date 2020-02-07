using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;
using System.Drawing;

namespace Traversa2.Views.MyItinenary
{
    public partial class CreateItinerary : System.Web.UI.Page
    {
        public List<Place> plList;
        public List<CatergoriesID> categoryList;
        public List<int> PPList = new List<int>();
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
                    plList = pl.GetAllPlacesByCat(Catid);

                    DataListIt.DataSource = plList;
                    DataListIt.DataBind();
                }
                else
                {
                    Place pl = new Place();
                    plList = pl.GetAllPlaces();

                    DataListIt.DataSource = plList;
                    DataListIt.DataBind();
                }
            }
        }


        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int CatId = Convert.ToInt32(e.CommandArgument);



                Place pl = new Place();
                plList = pl.GetAllPlacesByCat(CatId);

                DataListIt.DataSource = plList;
                DataListIt.DataBind();
            }
        }

        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            Place pl = new Place();
            plList = pl.GetAllPlaces();

            DataListIt.DataSource = plList;
            DataListIt.DataBind();
        }

        protected void DataListIt_ItemCommand(object source, DataListCommandEventArgs e)
        {


            if (e.CommandName == "viewPlace")
            {
                int PlaceID = Convert.ToInt32(e.CommandArgument);


                Session["PId"] = PlaceID.ToString();
                Response.Redirect("/Views/Places/ViewOnePlace.aspx");
            }

            if (e.CommandName == "AddPl")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                if (PPList.Contains(id))
                {
                    Label13.Text = "You have already added to your itinerary";
                }
                else
                {
                    PPList.Add(id);
                }



                if (PPList.Count > 9)
                {
                    Label13.Text = "You can only choose up to 10 places";
                }


            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Session["Listid"] = PPList;
            Response.Redirect("ViewItinerary.aspx");
        }
    }
}


