using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Menzy.Models;
using Menzy.ViewModels;
using System.Data.Entity;

namespace Menzy.Controllers
{
    public class FoodsController : Controller
    {
        private ApplicationDbContext _context;
        public FoodsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles=RoleName.CanManageFoods)]
        public ActionResult New()
        {
            var viewModel = new FoodFormViewModel { };
            return View("EditFoodForm", viewModel);
        }

        public ActionResult FoodForm()
        {
            var viewModel = new FoodFormViewModel
            {
            };
            return RedirectToAction("Index", "Foods");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Food food)
        {
            if (food.Name == null)
            {
                var viewModel = new FoodFormViewModel()
                {
                    Food = food
                };
                return View("FoodForm", viewModel);
            }

            if (food.Id == 0)
                _context.Foods.Add(food);
            else
            {
                var foodInDb = _context.Foods.Single(f => f.Id == food.Id);
                foodInDb.Name = food.Name;
                foodInDb.Price = food.Price;
                foodInDb.NumberInStock = food.NumberInStock;
                foodInDb.TipHrane = food.TipHrane;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Foods");
        }
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageFoods))
              return View("List");
            return View("ReadOnlyList");
        }
        public ActionResult Details(int id)
        {
            var food = _context.Foods.Include(f => f.TipHrane).SingleOrDefault(f => f.Id == id);
            if (food == null)
                return HttpNotFound();
            return View(food);
        }

        public ActionResult Edit(int id)
        {
            var food = _context.Foods.SingleOrDefault(f => f.Id == id);
            if (food == null)
                return HttpNotFound();
            var viewModel = new FoodFormViewModel
            {
                Food = food,
            };
            return View("FoodForm", viewModel);
        }
        // GET: Foods/Random
        public ActionResult Random()
        {
            var food = new Food() { Name = "POMFRI" };
            var viewResult = new ViewResult();
            var customers = new List<Customer>
            {
                new Customer {Name="C1"},
                new Customer {Name="C2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Food = food,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}