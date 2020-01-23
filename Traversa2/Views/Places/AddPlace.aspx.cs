using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class AddPlace : System.Web.UI.Page
    {
        public List<CatergoriesID> catList;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatergoriesID cc = new CatergoriesID();
                catList = cc.GetAll();
                              
                category.Items.Clear();
                category.Items.Insert(0, new ListItem("--Select--", "0"));
                category.AppendDataBoundItems = true;
                category.DataTextField = "CatName";
                category.DataValueField = "CatId";
                category.DataSource = catList;
                category.DataBind();
       
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}