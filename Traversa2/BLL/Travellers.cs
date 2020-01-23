using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Travellers
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Travellers()
        {

        }

        public Travellers(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public int AddNewUser()
        {
            UserDAO dao = new UserDAO();
            return (dao.Insert(this));
        }   
    }
}