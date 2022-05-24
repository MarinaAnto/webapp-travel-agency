using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Data;

namespace webapp_travel_agency.Controllers
{
    public class PackageController : Controller
    {

        Travel_AgencyContext db;
        public PackageController(Travel_AgencyContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
