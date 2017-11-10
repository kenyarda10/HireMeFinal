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
            MireMeEntities db = new MireMeEntities();
            jobPosting posting = db.jobPostings.SingleOrDefault(x => x.companyID == 3);

            PostingViewModel postingVM = new PostingViewModel();

            postingVM.jobDescription = posting.jobDescription;
            postingVM.jobTitle = posting.jobTitle;
            postingVM.companyID = posting.companyID;

            return View(postingVM);
        }
        
    }
}