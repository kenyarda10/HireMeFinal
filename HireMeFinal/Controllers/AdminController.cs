using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HireMeFinal.Abstract;
using HireMeFinal.Models;
using HireMeFinal.Entities;

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
        public ViewResult Index()
        {
            return View(repository.Postings);
        }

        public ViewResult Edit(int id)
        {
            Postings posting = repository.Postings.FirstOrDefault(p => p.jobPostingID == id);
            return View(posting);
        }

        [HttpPost]
        public ActionResult Edit(Postings posting)
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
    }
}