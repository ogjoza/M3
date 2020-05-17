using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Menzy.Models;

namespace Menzy.ViewModels
{
    public class RandomMovieViewModel
    {
        public Food Food { get; set; }
        public List<Customer> Customers { get; set; }
    }
}