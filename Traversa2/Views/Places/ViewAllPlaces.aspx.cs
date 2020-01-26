using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class ViewAllPlaces : System.Web.UI.Page
    {
        public List<Place> rateList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                BindData();
                lblMsg.Text = "";
            }

        }

        public void BindData()
        {
            Place pl = new Place();
            rateList = pl.GetAllPlaces();


            GVPlace.DataSource = rateList;
            GVPlace.DataBind();
        }

        protected void GVPlace_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GVPlace.DataKeys[e.RowIndex].Value);


            Place pl = new Place();
            pl.deleteOne(id);
            lblMsg.Text = "Entry successfully deleted!";
            lblMsg.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GVPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVPlace.SelectedRow;
            Session["PlaceId"] = row.Cells[0].Text;
            Response.Redirect("EditPlace.aspx");
        }
    }
}