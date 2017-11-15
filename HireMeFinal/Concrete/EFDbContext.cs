using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HireMeFinal.Models;

namespace HireMeFinal.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Models.jobPosting> Postings { get; set; }
    }
}