using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Recommendation
    {
        public string RName { get; set; }
        public string RReason { get; set; }

        public Recommendation()
        {
        }

        public Recommendation(string rname, string rreason)
        {
            this.RName = rname;
            this.RReason = rreason;
        }
        public int AddRecommendation()
        {
            RecDAO dao = new RecDAO();
            string test = RName;
            //null value here
            return (dao.Insert(this));
        }
    }
}