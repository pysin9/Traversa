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

        public int PlId { get; set; }
        public double AvgRating { get; set; }

        public Place()
        {

        }

        public Place(int plid, string pname, string pdesc, string plocation, int catid, string imagepath, double avgrating)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.PlId = plid;
            this.AvgRating = avgrating;
        }

        public Place(string pname, string pdesc, string plocation, int catid, string imagepath)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
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
    }
}