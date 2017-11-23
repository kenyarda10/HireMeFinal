//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace HireMeFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class studentProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public studentProfile()
        {
            this.educationDetails = new HashSet<educationDetail>();
            this.studentExperiences = new HashSet<studentExperience>();
            this.studentSkillSets = new HashSet<studentSkillSet>();
        }
        [Key, ForeignKey("userAccountID")]
        public int userAccountID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public int phone1 { get; set; }
        public int phone2 { get; set; }
        public int cellPhone { get; set; }
        public int cellProvider { get; set; }
        public string website { get; set; }
        public bool employerViewing { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educationDetail> educationDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentExperience> studentExperiences { get; set; }
        public virtual userAccount userAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentSkillSet> studentSkillSets { get; set; }
    }
}
