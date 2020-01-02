using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class RecommendPlace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRec_Click(object sender, EventArgs e)
        {
            string name = RName.Text;
            string reason = Request.Form["RReason"];
            string test1 = "qwerty";
            string test2 = "wasd";
            if (IsPostBack == true)
            {
                btnRec.Text = name;
                Recommendation rec = new Recommendation(name, reason);
                rec.AddRecommendation();
            }
            if(!IsPostBack)
            {
                btnRec.Text = name;
                Recommendation rec = new Recommendation(name, reason);
                Response.Write(rec.RName);
            }

        }
    }
}