using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Activity
    {
        public string AName { get; set; }
        public string ADesc { get; set; }
        public string ALocation { get; set; }
        public int CatId { get; set; }
        public string ImagePath { get; set; }
        public int AcId { get; set; }
        public string APrice { get; set; }
        public string AProvided { get; set; }
        public string ABring { get; set; }


        public Activity()
        {

        }

        public Activity(int acid, string aname, string adesc, string alocation, int catid, string imagepath, string aprice, string aprovided, string abring)
        {
            this.AName = aname;
            this.ADesc = adesc;
            this.ALocation = alocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.APrice = aprice;
            this.AProvided = aprovided;
            this.ABring = abring;
            this.AcId = acid;

        }

        public Activity(string aname, string adesc, string alocation, int catid, string imagepath, string aprice, string aprovided, string abring)
        {
            this.AName = aname;
            this.ADesc = adesc;
            this.ALocation = alocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.APrice = aprice;
            this.AProvided = aprovided;
            this.ABring = abring;
        }

        public int AddActivity()
        {
            ActivityDAO dao = new ActivityDAO();
            return (dao.Insert(this));
        }

        public List<Activity> GetAllPlaces()
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.GetAll();
        }

        public int DeleteOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.DeleteActivity(id);
        }

        public Activity RetrieveOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.getOne(id);
        }

        public int UpdateOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.UpdateActivity(this, id);
        }

        public List<Activity> GetAllActivityByCategory(int catId)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.SelectByCat(catId);
        }


    }
}