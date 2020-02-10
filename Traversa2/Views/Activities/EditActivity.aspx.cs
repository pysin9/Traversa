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
    public partial class EditActivity : System.Web.UI.Page
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
                if (Session["ActId"] != null)
                {
                    int acid = Convert.ToInt32(Session["ActId"]);
                    lblAcId.Text = acid.ToString();
                    Activity ac = new Activity();
                    ac = ac.RetrieveOne(acid);
                    if (ac != null)
                    {
                        AName.Text = ac.AName;
                        ADesc.Text = ac.ADesc;
                        ALocation.Text = ac.ALocation;
                        category.SelectedValue = ac.CatId.ToString();
                        string img = ac.ImagePath;
                        img = img.Replace("~/uploads/", "");
                        imgName.Text = img;
                        APrice.Text = ac.APrice;
                        AProvided.Text = ac.AProvided;
                        ABring.Text = ac.ABring;
                    }
                    else
                    {
                        Response.Redirect("AddActivity.aspx");
                    }
                }
                else
                {
                    Response.Redirect("AddActivity.aspx");
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = AName.Text;
            string desc = ADesc.Text;
            string loca = ALocation.Text;
            int cat = int.Parse(category.SelectedItem.Value);
            int acid = Convert.ToInt32(Session["ActId"]); 
            string cost = APrice.Text;
            string pvditem = AProvided.Text;
            string bringitem = ABring.Text;

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

                Activity ac = new Activity(name, desc, loca, cat, filePath, cost, pvditem, bringitem);

                int result = ac.UpdateOne(acid);
                if (result == 1)
                {
                    LblMsg.Text = "Activity successfully added!";
                    LblMsg.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("HostView.aspx");
                }
                else
                {
                    LblMsg.Text = "An error occured while adding, try again.";
                    LblMsg.ForeColor = System.Drawing.Color.Red;
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

                Activity ac = new Activity(name, desc, loca, cat, filePath, cost, pvditem, bringitem);

                int result = ac.UpdateOne(acid);
                if (result == 1)
                {
                    LblMsg.Text = "Activity successfully updated!";
                    LblMsg.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("HostView.aspx");
                }
                else
                {
                    LblMsg.Text = "An error occured while updating";
                    LblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("HostView.aspx");
        }
    }
}