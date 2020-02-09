using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Traversa2.BLL;

namespace Traversa2.Views.Places
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            var folder = Server.MapPath("~/uploads");
            string fileName = Path.GetFileName(FileUploadImage.PostedFile.FileName);
            string filePath = "~/uploads/" + fileName;
            //string fileExtension = Path.GetExtension(FileUploadImage.FileName);

           


            if (FileUploadImage.HasFile)
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    
                }
                else
                {
                    lblAlert.Text = "Folder already exists";
                }

                if (NameTB.Text == "")
                {
                    lblAlert.Text = "Category name cannot be empty";
                }
                else
                {
                    FileUploadImage.PostedFile.SaveAs(Server.MapPath(filePath));


                    CreateCategory cat = new CreateCategory(NameTB.Text, filePath);

                    int result = cat.AddNewCategory();
                    if (result == 1)
                    {
                        lblAlert.Text = "category created";
                        lblAlert.ForeColor = Color.Green;
                        Response.Redirect("ViewAllCategory.aspx");
                    }
                    else
                    {
                        lblAlert.Text = "Unable to create a category";
                        lblAlert.ForeColor = Color.Red;

                    }
                }

               
            }
            else
            {
                lblAlert.Text = "Please choose a file to upload";
                lblAlert.ForeColor = Color.Red;
            }


        }
    }
}