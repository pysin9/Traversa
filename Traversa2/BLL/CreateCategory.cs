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
        public int CatId { get; set; }
       
        public CreateCategory()
        {

        }

        public CreateCategory(string catname)
        {
            CatName = catname;
            //CatImage = catimage;
        }

        public int AddNewCategory()
        {
            CatDAO dao = new CatDAO();
            return (dao.insertCat(this));
        }

        public List<CreateCategory> GetAll()
        {
            CatDAO dao = new CatDAO();
            return dao.GetEverything();
        }

        public int DeleteSelected(int catId)
        {
            CatDAO dao = new CatDAO();
            return dao.DeleteCat(CatId);
        }
    }
}