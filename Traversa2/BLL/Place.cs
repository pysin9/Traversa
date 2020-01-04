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
        public string category { get; set; }
        public string image { get; set; }

        public Place()
        {

        }

        public Place(string pname, string pdesc, string plocation, string cat, string img)
        {
            this.PName = pname;
            this.PDesc = pdesc;
            this.PLocation = plocation;
            this.category = cat;
            this.image = img;
        }
    }
}