using HireMeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeFinal.Abstract
{
    public interface IPostingRepository
    {
        IEnumerable<Models.jobPosting> Postings { get; }

        void SavePosting(jobPosting posting);

        jobPosting DeletePostings(int postingsID);
    }
}
