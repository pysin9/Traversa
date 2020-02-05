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
        public string Date { get; set; }

        public string UserName { get; set; }

        public Rating()
        {

        }

        public Rating(int rating, string review, int userid, int placeid, string name, string datetime)
        {
            this.Rate = rating;
            this.Review = review;
            this.UserId = userid;
            this.PlaceId = placeid;
            this.UserName = name;
            this.Date = datetime;
        }

        public Rating(int rating, string review, int userid, int placeid, string datetime)
        {
            this.Rate = rating;
            this.Review = review;
            this.UserId = userid;
            this.PlaceId = placeid;
            this.Date = datetime;
        }

        public Rating(int rate, string review)
        {
            this.Rate = rate;
            this.Review = review;
        }

        public int addRating()
        {
            RatingDAO dao = new RatingDAO();
            return (dao.Insert(this));
        }

        public List<Rating> GetAllWherePlaceId(int id)
        {
            RatingDAO dao = new RatingDAO();
            return dao.GetAllOnPlaceId(id);
        }

        public Rating GetOneOnId(int userid, int placeid)
        {
            RatingDAO dao = new RatingDAO();
            return dao.RetrieveOne(userid, placeid);
        }

        public int Update()
        {
            RatingDAO dao = new RatingDAO();
            return dao.UpdateReview(this);
        }
    }
}