using Traversa2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traversa2.BLL
{
    public class Faq
    {
        // Define class properties
        public string FAQID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }




        // Default constructor
        public Faq()
        {

        }
        // Define a constructor to initialize all the properties
        public Faq(string faqid, string qns, string ans)
        {
            FAQID = faqid;
            Question = qns;
            Answer = ans;



        }






        public int AddFaq()
        {
            FaqDAO dao = new FaqDAO();
            int result = dao.Insert(this);
            return result;
        }
        public int UpdateFaq()
        {
            FaqDAO dao = new FaqDAO();
            int result = dao.Update(this);
            return result;
        }
        public List<Faq> GetAllFaq()
        {
            FaqDAO dao = new FaqDAO();
            return dao.SelectAll();
        }

        public Faq GetFaqById(string faqid)
        {
            FaqDAO dao = new FaqDAO();
            return dao.SelectById(faqid);
        }

    }
}