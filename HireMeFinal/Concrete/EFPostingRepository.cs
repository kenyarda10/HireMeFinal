using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMeFinal.Abstract;
using HireMeFinal.Models;

namespace HireMeFinal.Concrete
{
    public class EFPostingRepository : IPostingRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Models.jobPosting> Postings
        {
            get { return context.Postings; }
        }

        public void SavePosting(jobPosting posting)
        {
            if (posting.jobPostingID == 0)
            {
                context.Postings.Add(posting);
            }
            else
            {
                jobPosting dbEntry = context.Postings.Find(posting.jobPostingID);
                if (dbEntry != null)
                {
                    dbEntry.jobTitle = posting.jobTitle;
                    dbEntry.company = posting.company;
                    dbEntry.jobDescription = posting.jobDescription;
                }
            }
            context.SaveChanges();
        }

        public jobPosting DeletePostings(int postingID)
        {
            jobPosting dbEntry = context.Postings.Find(postingID);
            if (dbEntry != null)
            {
                context.Postings.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}