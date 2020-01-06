using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traversa2.DAL;

namespace Traversa2.BLL
{
    public class Recommendations
    {
        public string RName { get; set; }
        public string RReason { get; set; }
        public int RecID { get; set; }

        public Recommendations()
        {
        }

        public Recommendations(string rname, string rreason, int recid)
        {
            this.RName = rname;
            this.RReason = rreason;
            this.RecID = recid;
        }

        public List<Recommendations> GetAllRec()
        {
            RecDAO dao = new RecDAO();
            return dao.GetAll();
        }

        public int DeleteSelected(int recid)
        {
            RecDAO dao = new RecDAO();
            return dao.DeleteRec(recid);
        }
    }
}