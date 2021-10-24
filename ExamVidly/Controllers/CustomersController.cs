using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ExamVidly.Models;
using ExamVidly.ViewModels;

namespace ExamVidly.Controllers
{
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

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var membershipType = _context.MenMembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer =  new Customer(),
                MembershipTypes = membershipType,
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _context.MenMembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(m => m.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MenMembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(m => m.MembershipType).FirstOrDefault(m => m.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}