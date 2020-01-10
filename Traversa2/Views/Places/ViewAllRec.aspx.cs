using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class ViewAllRec : System.Web.UI.Page
    {
        public List<Recommendations> recList;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void GVRecs_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GVRecs.DataKeys[e.RowIndex].Value);

           

            Recommendations rec = new Recommendations();
            rec.DeleteSelected(id);
            lblMsg.Text = "Successfully deleted!";
            lblMsg.ForeColor = System.Drawing.Color.Green;
            BindData();

        }

        public void BindData()
        {
            Recommendations rec = new Recommendations();
            recList = rec.GetAllRec();

            
            GVRecs.DataSource = recList;
            GVRecs.DataBind();
        }
    }
}