using HireMeFinal.Entities;
using HireMeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireMeFinal.Controllers
{
    public class PostingController : Controller
    {
        public ActionResult Posting()
        {
            HireMeEntities db = new HireMeEntities();
            List<jobPosting> postingList = db.jobPostings.ToList();

            Postings postingVM = new Postings();

            List<Postings> postingVMList = postingList.Select(x=> new Postings
            {
                jobPostingID = x.jobPostingID,
                companyName = x.company.companyName,
                jobTitle = x.jobTitle,
                jobDescription = x.jobDescription
            }).ToList();


            return View(postingVMList);
        }
        
    }
}