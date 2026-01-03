using Microsoft.AspNetCore.Mvc;

namespace DNFSD_34.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            
            return RedirectToAction("StaffDashboard","School");
        } 
    }
}
