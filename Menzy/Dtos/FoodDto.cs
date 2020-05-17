using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Menzy.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Naziv")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Cijena")]
        public double Price { get; set; }

        public string TipHrane { get; set; }
        public int Kalorije { get; set; }
        public int Masti { get; set; }
        public int UHidrati { get; set; }
        public int Sol { get; set; }
        [Display(Name = "Raspoloživi broj")]
        public int NumberInStock { get; set; }

    }
}