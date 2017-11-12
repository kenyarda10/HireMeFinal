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
    
    public partial class userAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public userAccount()
        {
            this.jobPostActivities = new HashSet<jobPostActivity>();
            this.jobPostings = new HashSet<jobPosting>();
        }
    
        public int userAccountID { get; set; }
        public int userTypeID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool enabled { get; set; }
        public System.DateTime registrationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jobPostActivity> jobPostActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jobPosting> jobPostings { get; set; }
        public virtual studentProfile studentProfile { get; set; }
        public virtual userLog userLog { get; set; }
        public virtual userType userType { get; set; }
    }
}
