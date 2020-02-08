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

        public CatergoriesID(string catname, string catimage)
        {
            CatImage = catimage;
            CatName = catname;
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

        public List<CatergoriesID> Catbyid(int ca)
        {
            CatDAO dao = new CatDAO();
            return dao.SelectOne(ca);
        }

        public int Updateee(int id)
        {
            CatDAO dao = new CatDAO();
            return dao.UpdateCat(this, id);
        }

        public CatergoriesID Select(int id)
        {
            CatDAO dao = new CatDAO();
            return dao.getOne(id);
        }
		
		public List<CatergoriesID> GetBySearch(string substring)
        {
            CatDAO dao = new CatDAO();
            return dao.SearchFor(substring);
        }
    }
}