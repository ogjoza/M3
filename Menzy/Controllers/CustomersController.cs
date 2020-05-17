using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Menzy.Models;
using System.Data.Entity;
using System.IO.MemoryMappedFiles;
using AutoMapper;
using Menzy.ViewModels;

namespace Menzy.Controllers
{
    [Authorize(Roles = RoleName.CanManageFoods)]
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            
            var viewModel = new CustomerFormViewModel
            {
            };
            return View("CustomerForm", viewModel);
        }
        public ActionResult CustomerForm()
        {

            var viewModel = new CustomerFormViewModel
            {
            };
            return RedirectToAction("Index", "Customers");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (customer.Name == null)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id==0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.Redovni = customer.Redovni;

            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);

        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                
            };
            return View("CustomerForm",viewModel);
        }
    }
}