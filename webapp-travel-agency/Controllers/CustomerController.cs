using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Data;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Travel_AgencyContext _context;

        public CustomerController(Travel_AgencyContext  context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Customer> customers = _context.Customers.ToList();
            return View(customers);
        }
    }
}
