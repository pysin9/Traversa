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
        public List<Rating> ratelist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int placeid = Convert.ToInt32(Session["PlaceId"]);
                Place pl = new Place();
                pl = pl.retrieveOne(placeid);
                name.Text = pl.PName;
                desc.Text = pl.PDesc;
                location.Text = pl.PLocation;
                avgrating.Text = pl.AvgRating.ToString();
                image.ImageUrl = pl.ImagePath;
                category.Text = pl.CatName;
                region.Text = pl.Region;

                Rating rte = new Rating();
                ratelist = rte.GetAllWherePlaceId(placeid);
                DataList1.DataSource = ratelist;
                DataList1.DataBind();

                int userid = Convert.ToInt32(Session["UserId"]);
                int Num;
                bool isnum = Int32.TryParse(userid.ToString(), out Num);
                if (isnum)
                {
                    rte = rte.GetOneOnId(userid, placeid);
                    if (rte != null)
                    {
                        userrate.Text = rte.Rate.ToString();
                        usercomment.Text = rte.Review.ToString();
                    }
                    else
                    {
                        userrate.Visible = false;
                        usercomment.Visible = false;
                        Label7.Visible = false;
                        Label9.Visible = false;
                    }
                }
                else
                {
                    userrate.Visible = false;
                    usercomment.Visible = false;
                    Label7.Visible = false;
                    Label9.Visible = false;
                    thediv.Visible = false;
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Session["UserId"]);
            int placeid = Convert.ToInt32(Session["place"]);

            int rating = Convert.ToInt32(rdRate.SelectedValue);
            string com = Request.Form["comment"];
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            Rating rate = new Rating(rating, com, userid, placeid, date);

            if (userrate.Visible == false)
            {
                rate.addRating();
            }
            else
            {
                rate.Update();
            }
            Place pl = new Place();
            pl = pl.getavgrating(placeid);
            double avgrating = Convert.ToDouble(pl.AvgRating);
            Place place = new Place();
            place.updaterating(placeid, avgrating);
            Response.Redirect("~/Views/Places/ViewOnePlace.aspx");
        }
    }
}