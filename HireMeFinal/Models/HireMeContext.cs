using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HireMeFinal.Entities;

namespace HireMeFinal.Models
{
    public class HireMeContext : DbContext
    {
        public System.Data.Entity.DbSet<PostingViewModel> Postings { get; set; }
    }
}