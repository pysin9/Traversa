using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.MyItinenary
{
    public partial class CreateItinerary : System.Web.UI.Page
    {
        public List<Place> plList;
        public List<CatergoriesID> categoryList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                Place pl = new Place();
                plList = pl.GetAllPlaces();

                DataListPlaces.DataSource = plList;
                DataListPlaces.DataBind();

                CatergoriesID cat = new CatergoriesID();
                categoryList = cat.GetAll();

                DataListCategory.DataSource = categoryList;
                DataListCategory.DataBind();
            }
        }

        protected void LinkButtonPlaces_Click(object sender, EventArgs e)
        {

        }

        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int CatId = Convert.ToInt32(e.CommandArgument);



                Place pl = new Place();
                plList = pl.GetAllPlacesByCat(CatId);

                DataListPlaces.DataSource = plList;
                DataListPlaces.DataBind();
            }
        }

        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            
        }
    }
}