//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace graduation_project_ideas_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            this.members = new HashSet<members>();
            this.professors = new HashSet<professors>();
            this.projects = new HashSet<projects>();
            this.teamleaders = new HashSet<teamleaders>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter name...")]
        public string fullname { get; set; }
        [Required(ErrorMessage = "You must enter username...")]
        public string username { get; set; }
        [Required(ErrorMessage = "You must enter email...")]
        public string email { get; set; }
        [Required(ErrorMessage = "You must enter password...")]
        public string password { get; set; }
        public Nullable<int> usertype { get; set; }
        public Nullable<int> dept_id { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<members> members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professors> professors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projects> projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<teamleaders> teamleaders { get; set; }
    }
}