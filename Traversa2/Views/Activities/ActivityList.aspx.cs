using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;


namespace Traversa2.Views.Activities
{
    public partial class ActivityList : System.Web.UI.Page
    {
        public List<CatergoriesID> categoryList;
        public List<Activity> activityList;

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

                    Activity ac = new Activity();
                    activityList = ac.GetAllActivityByCategory(Catid);

                    DataListActivity.DataSource = activityList;
                    DataListActivity.DataBind();
                }
                else
                {

                }


            }

        }


        protected void LinkButtonActivity_Click(object sender, EventArgs e)
        {
            Activity ac = new Activity();
            activityList = ac.GetAllPlaces();

            Session["ActId"] = ac.AcId;

            Response.Redirect("ViewActivity.aspx");
        }

        protected void DataListCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int CatId = Convert.ToInt32(e.CommandArgument);



                Activity ac = new Activity();
                activityList = ac.GetAllActivityByCategory(CatId);

                DataListActivity.DataSource = activityList;
                DataListActivity.DataBind();
            }
        }

        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            Activity ac = new Activity();
            activityList = ac.GetAllPlaces();

            DataListActivity.DataSource = activityList;
            DataListActivity.DataBind();
        }
    }
}