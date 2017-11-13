using HireMeFinal.Entities;
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
        IEnumerable<Postings> Postings { get; }

        void SavePosting(Postings posting);

        Postings DeletePostings(int postingsID);
    }
}
