using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traversa2.BLL
{
    public class Rating
    {
        public int Rate { get; set; }
        public int Userid { get; set; }
        public int Placeid { get; set; }

        public Rating()
        {

        }

        public Rating(int rating, int userid, int placeid)
        {
            this.Rate = rating;
            this.Userid = userid;
            this.Placeid = placeid;
        }
    }
}