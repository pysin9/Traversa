using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class ViewOnePlace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = 13;
                //Convert.ToInt32(Session["PlaceId"]);
                Place pl = new Place();
                pl = pl.retrieveOne(id);
                name.Text = pl.PName;
                desc.Text = pl.PDesc;
                location.Text = pl.PLocation;
                avgrating.Text = pl.AvgRating.ToString();
                image.ImageUrl = pl.ImagePath;
            }
        }
    }
}