using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class EditCategory1 : System.Web.UI.Page
    {
        public List<CatergoriesID> cTlist;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Session["Catid"] != null)
                {
                    int id = Convert.ToInt32(Session["Catid"]);
                    CatergoriesID ca = new CatergoriesID();
                    ca = ca.Select(id);

                    //DataListk.DataSource = cTlist;
                    //DataListk.DataBind();

                    TextBoxName.Text = ca.CatName;
                    string img = ca.CatImage;
                    img = img.Replace("~/uploads/", "");
                    LabelCatName.Text = img;
                }
                else
                {
                    Response.Redirect("AddCategory.aspx");
                }
            }
        }



        protected void LinkButtonCreate_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;


            int plid = Convert.ToInt32(Session["CatId"]);

            if (FileUploadCat.HasFile)
            {
                var folder = Server.MapPath("~/uploads");
                string fileName = Path.GetFileName(FileUploadCat.PostedFile.FileName);
                string filePath = "~/uploads/" + fileName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                FileUploadCat.PostedFile.SaveAs(Server.MapPath(filePath));

                CatergoriesID pl = new CatergoriesID(name, filePath);

                int result = pl.Updateee(plid);
                if (result == 1)
                {
                    LblErrorr.Text = "Place successfully added!";
                    LblErrorr.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("ViewAllPlaces.aspx");
                }
                else
                {
                    LblErrorr.Text = "An error occured while adding, try again.";
                    LblErrorr.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                var folder = Server.MapPath("~/uploads");
                string fileName = LabelCatName.Text;
                string filePath = "~/uploads/" + fileName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                FileUploadCat.PostedFile.SaveAs(Server.MapPath(filePath));

                CatergoriesID pl = new CatergoriesID(name, filePath);

                int result = pl.Updateee(plid);
                if (result == 1)
                {
                    LblErrorr.Text = "Place successfully updated!";
                    LblErrorr.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("ViewAllPlaces.aspx");
                }
                else
                {
                    LblErrorr.Text = "An error occured while updating";
                    LblErrorr.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}