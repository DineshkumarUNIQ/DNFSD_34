using Microsoft.AspNetCore.Mvc;

namespace DNFSD_34.Controllers
{
    public class StudentCOntroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
