using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Menzy.Models
{
    public class Racun
    {
        public int Id { get; set; }
        [Required] public Customer Customer { get; set; }
        [Required] public Food Food { get; set; }
        public double Price { get; set; }
    }
}