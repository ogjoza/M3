using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Menzy.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [EmailAddress]
        public string EmailStud { get; set; }
       
        
        [Display(Name = "Redovni student?")]
        public byte TipStudentaId { get; set; }
        [Display(Name="Datum rođenja")]
        public DateTime? Birthdate { get; set; }
        public double Subvencija { get; set; }
        public string KojiFaks { get; set; }
        public string JMBAG { get; set; }
        public bool Redovni { get; set; }
    }
}