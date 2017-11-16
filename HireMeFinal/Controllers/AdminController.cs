using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HireMeFinal.Abstract;
using HireMeFinal.Models;

namespace HireMeFinal.Controllers
{
    public class AdminController : Controller
    {
        private IPostingRepository repository;
        // GET: Admin
        public AdminController(IPostingRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            Models.HireMeFinal db = new Models.HireMeFinal();

            List<Models.jobPosting> postingList = db.jobPostings.ToList();

            //PostingViewModel postingVM = new PostingViewModel();

            List<PostingViewModel> postingVMList = postingList.Select(x => new PostingViewModel()
            {
                jobPostingID = x.jobPostingID,
                jobTypeID = x.jobTypeID,
                companyID = x.companyID,
                jobLocationID = x.jobLocationID,
                userAccountID = x.userAccountID,
                jobCategoryID = x.jobCategoryID,
                applicantTypeID = x.applicantTypeID,
                createdDate = x.createdDate,
                numOpenings = x.numOpenings,
                hoursPerWeek = x.hoursPerWeek,
                wageSalary = x.wageSalary,
                startDate = x.startDate,
                endDate = x.endDate,
                qualifications=x.qualifications,
                applicationInstructions = x.applicationInstructions,
                applicationWebsite = x.applicationWebsite,
                postingDate = x.postingDate,
                expirationDate = x.expirationDate,
                enabled = x.enabled,
                numViews = x.numViews,
                jobTitle = x.jobTitle,
                jobType = x.jobType.jobTypeName,
                jobDescription = x.jobDescription,
                companyName = x.company.companyName
            }).ToList();

            return View(postingVMList);
        }
        /*       public ViewResult Index()
               {
                   return View(repository.Postings);
               }*/

        public ViewResult Edit(int id)
        {
            jobPosting posting = repository.Postings.FirstOrDefault(p => p.jobPostingID == id);
            return View(posting);
        }

        [HttpPost]
        public ActionResult Edit(jobPosting posting)
        {
            if (ModelState.IsValid)
            {
                repository.SavePosting(posting);
                TempData["message"] = string.Format("{0} has been saved", posting.jobTitle);
                return RedirectToAction("Index");
            }
            else
            {
                // invalid data inputs
                return View(posting);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new jobPosting());
        }

        [HttpPost]
        public ActionResult Delete(int postingID)
        {
            jobPosting deletedPostings = repository.DeletePostings(postingID);
            if (deletedPostings != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedPostings.jobTitle);
            }
            return RedirectToAction("Index");
        }
    }
}