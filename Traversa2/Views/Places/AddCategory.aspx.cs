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
           
            //HttpPostedFile postedFile = FileUploadImage.PostedFile;
            //string filename = Path.GetFileName(postedFile.FileName);
            //string fileExtension = Path.GetExtension(filename);
            //int filesize = postedFile.ContentLength;

            //if(fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".png" ||
                //fileExtension.ToLower() == ".gif")
            //{
                CreateCategory cat = new CreateCategory(NameTB.Text);

                int result = cat.AddNewCategory();
                if (result == 1)
                {
                    lblAlert.Text = "category created";
                    lblAlert.ForeColor = Color.Green;
                    
                }
                else
                {
                    lblAlert.Text = "Unable to create a category";
                    lblAlert.ForeColor = Color.Red;
                    
                }
            //}
            //else
            
            //{
               // lblAlert.Text = "Only images(.jpg, .png, .gif) can be uploaded";
                //lblAlert.ForeColor = Color.Red;
            //}
        }
    }
}