using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Activities
{
    public partial class HostView : System.Web.UI.Page
    {
        public List<Activity> activityList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                BindData();
                lblMsg.Text = "";
            }

        }

        public void BindData()
        {
            Activity ac = new Activity();
            activityList = ac.GetAllPlaces();

            GVActivity.Visible = true;
            GVActivity.DataSource = activityList;
            GVActivity.DataBind();
        }

        protected void GVActivity_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32(GVActivity.DataKeys[e.RowIndex].Value);
            Activity rec = new Activity();
            rec.deleteOne(id);
            lblMsg.Text = "Activity successfully deleted!";
            lblMsg.ForeColor = System.Drawing.Color.Green;
            BindData();
        }


        protected void GVActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVActivity.SelectedRow;
            Session["ActId"] = row.Cells[0].Text;
            Response.Redirect("EditActivity.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddActivity.aspx");
        }

    }
}