using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Users
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Users()
        {

        }

        public Users(string name, string password, string email)
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

        public Users GetTDbyEmail(string email)
        {
            UserDAO dao = new UserDAO();
            return dao.SelectByEmail(email);
        }
    }
}