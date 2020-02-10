using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;


namespace Traversa2.Views.MyItinenary
{
    public partial class Viewitinerary : System.Web.UI.Page
    {
        public List<Itinerary> iList;
        public List<Place> PL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Session["UserID"] != null)
                {
                    int userid = Convert.ToInt32(Session["UserID"]);
                    //Itinerary ui = new Itinerary();
                    //ui = ui.selectbyuserid(userid);
                    //if (ui != null)
                    //{
                    Itinerary ii = new Itinerary();
                    iList = ii.retrieveAll(userid);

                    if(iList == null)
                    {
                        DataListItinName.Visible = false;
                        LabelMessage.Visible = true;
                    }
                    else
                    {
                        DataListItinName.Visible = true;
                        DataListItinName.DataSource = iList;
                        DataListItinName.DataBind();

                        LabelMessage.Visible = false;
                    }


                    


                    //}
                    //else
                    //{
                    //    DataListItinName.Visible = false;
                    //    LabelMessage.Visible = true;
                    //}

                }
            }
        }



        protected void LbtnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimeAndDate.aspx");
        }

        protected void DataListItinName_ItemCommand(object source, DataListCommandEventArgs e)
        {


            if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);

                Itinerary it = new Itinerary();
                it.dell(id);
                Labelerr.Text = "Successfully deleted";
                Labelerr.ForeColor = System.Drawing.Color.Green;
            }

            if (e.CommandName == "Edit")
            {
                int id = Convert.ToInt32(e.CommandArgument);

                Session["ItinId"] = id.ToString();
                Response.Redirect("EditItinerary.aspx");
            }
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