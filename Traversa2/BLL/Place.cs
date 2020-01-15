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
        public string Category { get; set; }
        public string ImageData { get; set; }

        public Place()
        {

        }

        public Place(string pname, string pdesc, string plocation, string category, string imagedata)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.Category = category;
        }

        public int AddPlace()
        {
            PlaceDAO dao = new PlaceDAO();
            return (dao.Insert(this));
        }
    }
}