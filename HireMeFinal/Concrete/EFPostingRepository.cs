using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMeFinal.Abstract;
using HireMeFinal.Models;
using HireMeFinal.Entities;

namespace HireMeFinal.Concrete
{
    public class EFPostingRepository : IPostingRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Postings> Postings
        {
            get { return context.Postings; }
        }

        public void SavePosting(Postings posting)
        {
            if (posting.jobPostingID == 0)
            {
                context.Postings.Add(posting);
            }
            else
            {
                Postings dbEntry = context.Postings.Find(posting.jobPostingID);
                if (dbEntry != null)
                {
                    dbEntry.jobTitle = posting.jobTitle;
                    dbEntry.companyName = posting.companyName;
                    dbEntry.jobDescription = posting.jobDescription;
                }
            }
            context.SaveChanges();
        }
    }
}