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

        public Itinerary(int placeid, string Name, int userid)
        {
            PlId = placeid;
            IName = Name;
            UserId = userid;
        }

        public Itinerary(int ITid, string Name, int placeid, int userid)
        {
            ITinId = ITid;
            IName = Name;
            PlId = placeid;

            UserId = userid;
        }

        public Itinerary(int itid, string itname, int placeid, int userid, string pname, string Image, double avgrate)
        {
            ITinId = itid;
            IName = itname;
            PlId = placeid;
            UserId = userid;
            PName = pname;
            image = Image;
            Avgrate = avgrate;

        }

        public int Addnew()
        {
            ItinDAO dao = new ItinDAO();
            return (dao.Insert(this));
        }

        public List<Itinerary> retrieveAll(int id)
        {
            ItinDAO dao = new ItinDAO();
            return dao.GetAll(id);
        }

        public Itinerary selectbyuserid(int ID)
        {
            ItinDAO dao = new ItinDAO();
            return dao.SelectByuserid(ID);
        }

        public Itinerary selectbyidd(int ID)
        {
            ItinDAO dao = new ItinDAO();
            return dao.SelectByitin(ID);
        }

        public int dell(int idd)
        {
            ItinDAO dao = new ItinDAO();
            return dao.DeleteIT(idd);
        }

        public int updateOne(int id)
        {
            ItinDAO dao = new ItinDAO();
            return dao.UpdateIT(this, id);
        }
    }
}