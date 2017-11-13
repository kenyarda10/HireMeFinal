using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HireMeFinal.Entities
{
    public class Postings
    {
        [HiddenInput(DisplayValue = false)]
        public int jobPostingID { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage="Please enter a job description")]
        [Display(Name="Job Description")]
        public string jobDescription { get; set; }
        [Required(ErrorMessage = "Please enter a job title")]
        [Display(Name = "Job Title")]
        public string jobTitle { get; set; }
        [Display(Name = "Company Name")]
        public string companyName { get; set; }
    }
}