using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Place
    {
        public string PName { get; set; }
        public string PDesc { get; set; }
        public string PLocation { get; set; }
        public int CatId { get; set; }
        public string ImagePath { get; set; }
        public string Region { get; set; }

        public int PlId { get; set; }
        public double AvgRating { get; set; }
        public string CatName { get; set; }

        public Place()
        {

        }
        public Place(double avgrating)
        {
            this.AvgRating = avgrating;
        }
        public Place(int plid, string pname, string pdesc, string plocation, int catid, string imagepath, double avgrating, string catname, string region)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.PlId = plid;
            this.AvgRating = avgrating;
            this.CatName = catname;
            this.Region = region;
        }

        public Place(int plid, string pname, string pdesc, string plocation, int catid, string imagepath, double avgrating, string region)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.PlId = plid;
            this.AvgRating = avgrating;
            this.Region = region;
        }

        public Place(string pname, string pdesc, string plocation, int catid, string imagepath, string region)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.Region = region;
        }

        public int AddPlace()
        {
            PlaceDAO dao = new PlaceDAO();
            return (dao.Insert(this));
        }

        public List<Place> GetAllPlaces()
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.GetAll();
        }

        public int deleteOne(int id)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.DeletePlace(id);
        }

        public Place retrieveOne(int id)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.getOne(id);
        }

        public int updateOne(int id)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.UpdatePlace(this, id);
        }

        public List<Place> GetAllPlacesByCat(int catId)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.SelectByCat(catId);
        }

        public Place getavgrating(int id)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.GetAvgRating(id);
        }

        public int updaterating(int id, double rating)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.UpdateRating(id, rating);
        }
        public List<Place> GetBySearch(string substring)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.SearchFor(substring);
        }

        public List<Place> GetTop3Rating()
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.gettoprating();
        }

        public List<Place> SelectByRegion(string reg)
        {
            PlaceDAO dao = new PlaceDAO();
            return dao.selectregion(reg);
        }
    }
}