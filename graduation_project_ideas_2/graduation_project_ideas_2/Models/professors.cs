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

    public partial class professors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public professors()
        {
            this.orders = new HashSet<orders>();
        }

        public int Id { get; set; }
        [Required]
        [Range(1, 50)]
        public Nullable<int> exp_year { get; set; }
        [Required]
        public string pro_desc { get; set; }
        public string pro_depart { get; set; }
        public Nullable<int> pro_user { get; set; }
        [Required]
        public Nullable<int> dept_id { get; set; }


        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders> orders { get; set; }
        public virtual users users { get; set; }
    }
}
