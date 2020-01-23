using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class CatergoriesID
    {
        public string CatName { get; set; }
        public int CatId { get; set; }
        public string CatImage { get; set; }

        public CatergoriesID()
        {

        }

        public CatergoriesID(int catID, string catName, string catImage)
        {
            CatId = catID;
            CatName = catName;
            CatImage = catImage;
        }


        public List<CatergoriesID> GetAll()
        {
            CatDAO cat = new CatDAO();
            return cat.GetEverything();
        }

        public int DeleteSelected(int catId)
        {
            CatDAO dao = new CatDAO();
            return dao.DeleteCat(catId);
        }
    }
}