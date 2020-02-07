using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Traversa2.BLL;

namespace Traversa2.Views.Activities
{
    public partial class AddActivity : System.Web.UI.Page
    {

        public List<CatergoriesID> catList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("HostView.aspx");
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = AName.Text;
            string desc = ADesc.Text;
            string loca = ALocation.Text;
            int cat = int.Parse(category.SelectedItem.Value);

            var folder = Server.MapPath("~/uploads");
            string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
            string filePath = "~/uploads/" + fileName;

            string ppl = APeople.Text;
            string cost = APrice.Text;
            string pvditem = AProvided.Text;
            string bringitem = ABring.Text;


            imgName.Text = fileName.ToString();

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);

            }
            FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

            Activity ac = new Activity(name, desc, loca, cat, filePath, ppl, cost, pvditem, bringitem);

            int result = ac.AddActivity();
            if (result == 1)
            {
                LblMsg.Text = "Activity successfully added!";

                LblMsg.ForeColor = System.Drawing.Color.Green;
                AName.Text = "";
                ADesc.Text = "";
                ALocation.Text = "";
                category.ClearSelection();
                imgName.Text = "";

                APeople.Text = "";
                APrice.Text = "";
                AProvided.Text = "";
                ABring.Text = "";

                Response.Redirect("HostView.aspx");
            }
            else
            {
                LblMsg.Text = "An error occured while adding, try again.";
                LblMsg.ForeColor = System.Drawing.Color.Red;
            }

        }

    }
}