using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class CreateCategory
    {
        public string CatName { get; set; }
        //public HttpPostedFile CatImage { get; set; }
        public string CatImage{ get; set; }
       
        public CreateCategory()
        {

        }

        public CreateCategory(string catname, string catimage)
        {
            CatName = catname;
            CatImage = catimage;
        }

        public int AddNewCategory()
        {
            CatDAO dao = new CatDAO();
            return (dao.insertCat(this));
        }

        

    
    }
}