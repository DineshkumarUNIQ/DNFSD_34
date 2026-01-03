using Microsoft.AspNetCore.Mvc;

namespace DNFSD_34.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
