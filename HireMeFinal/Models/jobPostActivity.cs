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
    
    public partial class jobPostActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public jobPostActivity()
        {
            this.jobPostActivityLogs = new HashSet<jobPostActivityLog>();
        }
    
        public int jobPostActivityID { get; set; }
        public int userAccountID { get; set; }
        public int jobPostingID { get; set; }
        public System.DateTime applyDate { get; set; }
        public int jobApplicationStatusID { get; set; }
    
        public virtual jobApplicationStatu jobApplicationStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jobPostActivityLog> jobPostActivityLogs { get; set; }
        public virtual userAccount userAccount { get; set; }
        public virtual jobPosting jobPosting { get; set; }
    }
}
