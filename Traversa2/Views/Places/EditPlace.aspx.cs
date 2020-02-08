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
    public partial class EditPlace : System.Web.UI.Page
    {
        public List<CatergoriesID> catList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
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
                if (Session["PlaceId"] != null)
                {
                    int id = Convert.ToInt32(Session["PlaceId"]);
                    Place pl = new Place();
                    pl = pl.retrieveOne(id);
                    if (pl != null)
                    {
                        Pname.Text = pl.PName;
                        PDesc.Text = pl.PDesc;
                        PLocation.Text = pl.PLocation;
                        category.SelectedValue = pl.CatId.ToString();
                        region.SelectedValue = pl.Region;
                        string img = pl.ImagePath;
                        img = img.Replace("~/uploads/", "");
                        imgName.Text = img;
                    }
                    else
                    {
                        Response.Redirect("~/Views/Places/AddPlace.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Places/AddPlace.aspx");
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = Pname.Text;
            string desc = PDesc.Text;
            string loca = PLocation.Text;
            int cat = int.Parse(category.SelectedItem.Value);
            int plid = Convert.ToInt32(Session["PlaceId"]);
            string reg = region.SelectedItem.Value;

            if (FileUpload.HasFile)
            {
                var folder = Server.MapPath("~/uploads");
                string fileName = Path.GetFileName(FileUpload.PostedFile.FileName);
                string filePath = "~/uploads/" + fileName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

                Place pl = new Place(name, desc, loca, cat, filePath, reg);

                int result = pl.updateOne(plid);
                if (result == 1)
                {
                    lblMsg.Text = "Place successfully added!";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("ViewAllPlaces.aspx");
                }
                else
                {
                    lblMsg.Text = "An error occured while adding, try again.";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                var folder = Server.MapPath("~/uploads");
                string fileName = imgName.Text;
                string filePath = "~/uploads/" + fileName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                FileUpload.PostedFile.SaveAs(Server.MapPath(filePath));

                Place pl = new Place(name, desc, loca, cat, filePath, reg);

                int result = pl.updateOne(plid);
                if (result == 1)
                {
                    lblMsg.Text = "Place successfully added!";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("~/Views/Places/ViewAllPlaces.aspx");
                }
                else
                {
                    lblMsg.Text = "An error occured while adding, try again.";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Places/ViewAllPlaces.aspx");
        }
    }
}