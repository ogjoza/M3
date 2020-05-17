using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Menzy.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Naziv")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Cijena")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Tip hrane")]
        public string TipHrane { get; set; }
        public int Kalorije { get; set; }
        public int Masti { get; set; }
        [Display(Name = "Ugljiko hidrati")]
        public int UHidrati { get; set; }
        public int Sol { get; set; }
        [Display(Name = "Raspoloživi broj")]
        public int NumberInStock { get; set; }

    }
}