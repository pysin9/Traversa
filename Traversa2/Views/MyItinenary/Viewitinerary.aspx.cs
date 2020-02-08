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
        public List<Place> PL;
        public List<int> plidList = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Session["UserID"] != null)
                {
                    LabeID.Text = Session["UserID"].ToString();
                    LabeID.Visible = false;
                    Itinerary i = new Itinerary();


                    //DataListItinName.Visible = true;
                    //DataListItinName.DataSource = iList;
                    //DataListItinName.DataBind();

                    LabelMessage.Visible = false;
                }

               
                






            }
        }







        

        protected void LinkButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateItinerary.aspx");
        }

        protected void LbtnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimeAndDate.aspx");
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