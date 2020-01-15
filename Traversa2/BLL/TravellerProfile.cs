using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class TravellerProfile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FoodPref { get; set; }
        public string Language { get; set; }

        public TravellerProfile()
        {

        }

        public TravellerProfile(int id, string name, string email, string foodpref, string language)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.FoodPref = foodpref;
            this.Language = language;
        }

        public int UpdateProifle()
        {
            UserDAO dao = new UserDAO();
            return dao.UpdateProfile(this);
        }

        //retrieve one result
    }
}