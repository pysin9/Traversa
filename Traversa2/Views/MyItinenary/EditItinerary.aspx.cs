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
    public partial class EditItinerary : System.Web.UI.Page
    {
        public List<Place> pll;
        public List<Place> rll;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Place pl = new Place();
                pll = pl.GetAllPlaces();

                DDLPlaces.Items.Clear();
                DDLPlaces.Items.Insert(0, new ListItem("--Select--", "0"));
                DDLPlaces.AppendDataBoundItems = true;
                DDLPlaces.DataTextField = "PName";
                DDLPlaces.DataValueField = "PlId";
                DDLPlaces.DataSource = pll;
                DDLPlaces.DataBind();

                Place ppl = new Place();
                rll = ppl.GetTop3Rating();

                DatalistRating.DataSource = rll;
                DatalistRating.DataBind();

                if (Session["ItinId"] != null)
                {
                    int id = Convert.ToInt32(Session["ItinId"]);
                    Itinerary ii = new Itinerary();
                    ii = ii.selectbyidd(id);
                    if (ii != null)
                    {
                        NameTB.Text = ii.IName;

                        DDLPlaces.SelectedValue = ii.PlId.ToString();

                    }
                    else
                    {
                        Response.Redirect("TimeAndDate.aspx");
                    }
                }
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "")
            {
                Labelerr.Text = "Name is required";
                Labelerr.ForeColor = Color.Red;
            }
            if (DDLPlaces.SelectedIndex == -1)
            {
                Labelerr.Text = "You need to choose a place";
                Labelerr.ForeColor = Color.Red;
            }
            //if(TextBoxDate.Text == "")
            //{
            //    Labelerr.Text = "You need to choose a date";

            //}
            else
            {
                int placeid = int.Parse(DDLPlaces.SelectedItem.Value);
                string name = NameTB.Text;
                int userId = Convert.ToInt32(Session["UserID"].ToString());
                int id = Convert.ToInt32(Session["ItinId"]);


                Labelerr.Text = placeid.ToString();
                Itinerary it = new Itinerary(placeid, name);
                int res = it.updateOne(id);
                if (res == 1)
                {
                    Labelerr.Text = "Successfully created";
                    Labelerr.ForeColor = Color.Green;
                    Response.Redirect("ViewItinerary.aspx");
                }
                else
                {
                    Labelerr.Text = "Error";
                    Labelerr.ForeColor = Color.Green;
                }



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
    }
}