using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HireMeFinal.Models;
using HireMeFinal.Entities;

namespace HireMeFinal.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Postings> Postings { get; set; }
    }
}