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
    
    public partial class educationDetail
    {
        public int userAccountID { get; set; }
        public string certificateDegree { get; set; }
        public string major { get; set; }
        public string institutionName { get; set; }
        public System.DateTime startDate { get; set; }
        public Nullable<System.DateTime> completionDate { get; set; }
        public Nullable<int> percentage { get; set; }
        public Nullable<int> gpa { get; set; }
    
        public virtual studentProfile studentProfile { get; set; }
    }
}
