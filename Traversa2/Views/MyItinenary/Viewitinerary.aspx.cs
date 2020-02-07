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
    public partial class Viewitinerary : System.Web.UI.Page
    {
        public List<Itinerary> iList;
        public List<int> plidList = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = 3;
            Session["UserID"] = id.ToString();
            if (IsPostBack == false)
            {
                if (Session["UserID"] != null)
                {
                    LabeID.Text = Session["UserID"].ToString();
                    LabeID.Visible = false;
                    Itinerary i = new Itinerary();
                    iList = i.GetEverything();

                    //DataListItinName.Visible = true;
                    //DataListItinName.DataSource = iList;
                    //DataListItinName.DataBind();

                    LabelMessage.Visible = false;
                }

                if (Session["Listid"] != null)
                {
                    plidList = (List<int>)Session["Listid"];
                    foreach ()
                }






            }
        }







        protected void LinkButtonCreate_Click(object sender, EventArgs e)
        {
            if (TBName.Text == "")
            {
                Labelerr.Text = " Itinerary Name is required";
                Labelerr.ForeColor = Color.Red;
            }
            else
            {
                LabeID.Visible = true;
                int userid = Convert.ToInt32(LabeID.Text);
                LabeID.Visible = false;
                string itinName = TBName.Text;

                Itinerary it = new Itinerary(itinName, userid);
                int res = it.Addnew();
                if (res == 1)
                {
                    Labelerr.Text = "Itinerary Created created";
                    Labelerr.ForeColor = Color.Green;
                    Response.Redirect("ViewItinerary.aspx");
                }
                else
                {
                    Labelerr.Text = "Unable to create a itinerary";
                    Labelerr.ForeColor = Color.Red;

                }







            }
        }

        protected void LinkButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateItinerary.aspx");
        }




        //protected void DataListItinName_ItemCommand(object source, DataListCommandEventArgs e)
        //{
        //    if(e.CommandName == "Addd")
        //    {
        //         string Iname =  e.CommandArgument.ToString();



        //        Session["INAME"] = Iname;
        //        Response.Redirect("CreateItinerary.aspx");
        //    }
        //}



        //protected void CalendarDate_SelectionChanged(object sender, EventArgs e)
        //{
        //    TextBoxDate.Text = CalendarDate.SelectedDate.ToShortDateString();
        //}

        //protected void DataListItinName_ItemCommand(object source, DataListCommandEventArgs e)
        //{

        //}

        //protected void ImageButtonDate_Click(object sender, ImageClickEventArgs e)
        //{
        //    if (CalendarDate.Visible == false)
        //    {
        //        CalendarDate.Visible = true;
        //    }
        //    else
        //    {
        //        CalendarDate.Visible = false;
        //    }
        //}
    }
}