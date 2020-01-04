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
        public List<Recommendation> recList;
        protected void Page_Load(object sender, EventArgs e)
        {
            Recommendation rec = new Recommendation();
            recList = rec.GetAllRec();

            //GVRec.DataSource = rateList;
            //GVRec.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Recommendation rec = new Recommendation();
        }
    }
}