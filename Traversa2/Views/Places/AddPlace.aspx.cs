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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = Pname.Text;
            string desc = PDesc.Text;
            string loca = PLocation.Text;
            int cat = int.Parse(category.SelectedItem.Value);

            var folder = Server.MapPath("~/uploads");
            string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
            string filePath = "~/uploads/" + fileName;

            imgName.Text = fileName.ToString();

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);

            }
            FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

            Place pl = new Place(name, desc, loca, cat, filePath);
                    
            int result = pl.AddPlace();
            if (result == 1)
            {
                lblMsg.Text = "Place successfully added!";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                Pname.Text = "";
                PDesc.Text = "";
                PLocation.Text = "";
                category.ClearSelection();
                imgName.Text = "";
            }
            else
            {
                lblMsg.Text = "An error occured while adding, try again.";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}