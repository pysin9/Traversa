﻿using System;
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

        public Activity()
        {

        }

        public Activity(int acid, string aname, string adesc, string alocation, int catid, string imagepath)
        {
            this.AName = aname;
            this.ADesc = adesc;
            this.ALocation = alocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
            this.AcId = acid;
        }

        public Activity(string aname, string adesc, string alocation, int catid, string imagepath)
        {
            this.AName = aname;
            this.ADesc = adesc;
            this.ALocation = alocation;
            this.CatId = catid;
            this.ImagePath = imagepath;
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

        public int deleteOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.DeleteActivity(id);
        }

        public Activity retrieveOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.getOne(id);
        }

        public int updateOne(int id)
        {
            ActivityDAO dao = new ActivityDAO();
            return dao.UpdateActivity(this, id);
        }


    }
}