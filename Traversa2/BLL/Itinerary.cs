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
        public DateTime selectDate { get; set; }
        public DateTime selectTime { get; set; }
        public int ITinId { get; set; }
       

        public int PlId { get; set; }
        public int UserId { get; set; }

        public Itinerary()
        {

        }

        public Itinerary(int itinId , int plId, string Iname, DateTime seldate, DateTime selTime, int UserID)
        {
            ITinId = itinId;
            PlId = plId;
            IName = Iname;
            selectDate = seldate;
            selectTime = selTime;
            UserId = UserID;
        }

        public int Addnew()
        {
            ItinDAO dao = new ItinDAO();
            return (dao.Insert(this));
        }
    }
}