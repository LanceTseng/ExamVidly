using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamVidly.Models;
using ExamVidly.ViewModels;
using Microsoft.Ajax.Utilities;
using Microsoft.Owin.Security;

namespace ExamVidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // GET: Customers/Detail
        public ActionResult Details(int Id)
        {

            var customer = GetCustomers().FirstOrDefault(m => m.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Id = 1, Name = "John Smith" },
                new Customer() {Id = 2, Name = "Mary Williams" }
            };
        }

    }
}