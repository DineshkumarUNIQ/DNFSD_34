using Microsoft.AspNetCore.Mvc;

namespace DNFSD_34.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
