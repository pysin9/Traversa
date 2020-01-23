using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Rating
    {
        public int Rate { get; set; }
        public string Review { get; set; }
        public int UserId { get; set; }
        public int PlaceId { get; set; }

        public Rating()
        {

        }

        public Rating(int rating, string review, int userid, int placeid)
        {
            this.Rate = rating;
            this.Review = Review;
            this.UserId = userid;
            this.PlaceId = placeid;
        }

        //public int addRating()
        //{
        //    RatingDAO dao = new RatingDAO();
        //    return (dao.Insert(this));
        //}
    }
}