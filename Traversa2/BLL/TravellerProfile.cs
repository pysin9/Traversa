﻿using System;
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
		public string Style { get; set; }

        public TravellerProfile()
        {

        }

         public TravellerProfile(int id, string name, string email, string foodpref, string language, string style)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.FoodPref = foodpref;
            this.Language = language;
			this.Style = style;
        }

        public int UpdateProifle()
        {
            UserDAO dao = new UserDAO();
            return dao.UpdateProfile(this);
        }

        public TravellerProfile GetbyEmail(string email)
        {
            UserDAO dao = new UserDAO();
            return dao.SelectByEmail(email);
        }
        public TravellerProfile RetrieveOne(int ID)
        {
            UserDAO dao = new UserDAO();
            return dao.SelectById(ID);
        }

        public int ChangePassword(int UserID, string psd)
        {
            UserDAO dao = new UserDAO();
            return dao.UpdatePassword(UserID, psd);
        }
    }
}