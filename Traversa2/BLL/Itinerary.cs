using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Itinerary
    {
        public string IName { get; set; }
        public string selectDate { get; set; }
        public string selectTime { get; set; }
        public int ITinId { get; set; }
        public string PName { get; set; }
        public double Avgrate { get; set; }
        public string image { get; set; }
        public int PlId { get; set; }
        public int UserId { get; set; }
        public int PlaceId { get; set; }

        public Itinerary()
        {

        }

        public Itinerary(int itinId, int plId, string Iname, string seldate, string selTime, int UserID)
        {
            ITinId = itinId;
            PlId = plId;
            IName = Iname;
            selectDate = seldate;
            selectTime = selTime;
            UserId = UserID;
        }

        public Itinerary(string Name, int userid)
        {
            IName = Name;
            UserId = userid;
        }

        public Itinerary(int ITid, string Name, int userid)
        {
            ITinId = ITid;
            IName = Name;
            UserId = userid;
        }

        public Itinerary(int placeid)
        {
            PlId = placeid;
        }

        public Itinerary(string itname)
        {
            IName = itname;
        }

        public Itinerary(int itid, string itname, int placeid, int userid, int plid, string pname, string Image, double avgrate)
        {
            ITinId = itid;
            IName = itname;
            PlId = placeid;
            UserId = userid;
            PlaceId = plid;
            image = Image;
            Avgrate = avgrate;

        }

        public int Addnew()
        {
            ItinDAO dao = new ItinDAO();
            return (dao.Insert(this));
        }

        public int addId(int id, string name)
        {
            ItinDAO dao = new ItinDAO();
            return (dao.InsertPlId(this, id, name));
        }

        public List<Itinerary> GetEverything()
        {
            ItinDAO cat = new ItinDAO();
            return cat.Getall();
        }

        public Itinerary getname(int ID)
        {
            ItinDAO dao = new ItinDAO();
            return dao.getOne(ID);
        }

        public List<Itinerary> GetALL()
        {
            ItinDAO cat = new ItinDAO();
            return cat.GetEverything();
        }
    }
}