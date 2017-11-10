using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeFinal.Models
{
    public class PostingViewModel
    {
        public int jobPostingID { get; set; }
        public int jobTypeID { get; set; }
        public int companyID { get; set; }
        public int jobLocationID { get; set; }
        public int userAccountID { get; set; }
        public int jobCategoryID { get; set; }
        public int applicantTypeID { get; set; }
        public System.DateTime createdDate { get; set; }
        public string jobDescription { get; set; }
        public string jobTitle { get; set; }
        public int numOpenings { get; set; }
        public int hoursPerWeek { get; set; }
        public decimal wageSalary { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }
        public string qualifications { get; set; }
        public string applicationInstructions { get; set; }
        public string applicationWebsite { get; set; }
        public System.DateTime postingDate { get; set; }
        public System.DateTime expirationDate { get; set; }
        public bool enabled { get; set; }
        public int numViews { get; set; }
    }
}