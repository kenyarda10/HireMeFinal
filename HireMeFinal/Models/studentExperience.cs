//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HireMeFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class studentExperience
    {
        [Key]
        public int userAccountID { get; set; }
        public bool currentJob { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }
        public string jobTitle { get; set; }
        public string companyName { get; set; }
        public string jobCity { get; set; }
        public string jobState { get; set; }
        public string jobCountry { get; set; }
        public string description { get; set; }
    
        public virtual studentProfile studentProfile { get; set; }
    }
}
