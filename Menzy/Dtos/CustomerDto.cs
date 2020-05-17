using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Menzy.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string EmailStud { get; set; }
        public byte TipStudentaId { get; set; }
        public DateTime? Birthdate { get; set; }
        public double Subvencija { get; set; }
        public string KojiFaks { get; set; }
        public string JMBAG { get; set; }
        public bool Redovni { get; set; }
    }
}
