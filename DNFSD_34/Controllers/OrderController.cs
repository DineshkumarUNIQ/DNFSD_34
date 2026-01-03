using Microsoft.AspNetCore.Mvc;

namespace DNFSD_34.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
