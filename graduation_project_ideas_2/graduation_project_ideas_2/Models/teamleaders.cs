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

    public partial class teamleaders
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "d5l el gpa w mttksfsh :D)...")]
        [Range(1, 4, ErrorMessage = "ant ht7wr :D)...")]
        public Nullable<double> std_gpa { get; set; }
        [Required(ErrorMessage = "abhrny b mahratak :D)...")]
        public string std_skills { get; set; }
        [Required(ErrorMessage = "arf3 ntigtak w mttksfsh ya handsa :D)...")]
        public string std_trans { get; set; }
        [Required(ErrorMessage = "d5l level bt3ak ya handsa :D)...")]
        [Range(1, 4, ErrorMessage = "a5rk m3ana rab3a m3lsh :D)...")]
        public string std_level { get; set; }
        public Nullable<int> user_id { get; set; }

        public virtual users users { get; set; }
    }
}