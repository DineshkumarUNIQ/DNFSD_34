using DNFSD_34.Models;
using DNFSD_34.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DNFSD_34.Controllers
{
    public class SchoolController : Controller
    {
       private readonly ApplicationDB ctx;
        public SchoolController(ApplicationDB _ctx)  //  = new ApplicationDB()
        {
            ctx= _ctx;
        }
        [HttpGet]
        public IActionResult Search(string input) //  "Arun" "234567"
        {
            long Mobile; // 0
               long.TryParse(input, out Mobile);

            var customer = ctx.Customers.Where(x => 
            x.Name.Contains(input) || x.Email.Contains(input) || x.Phone == Mobile).ToList();
            return View("ReadCustomer",customer);
        }


        [HttpGet]
        public IActionResult ReadCustomer()
        {
            try
            {
                List<Customer> customer = ctx.Customers.ToList();
                return View(customer);
            }
            catch (Exception ex) 
            {
                List<Customer> customer = new List<Customer>(); 
                return View(customer);
            }
           
        }
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "Insert All mandatory fields !!";
                return View();
            }
            try
            {
                ctx.Customers.Add(customer);
                ctx.SaveChanges();
                TempData["a"] = "Data Stored Successfully !!";
                return RedirectToAction("ReadCustomer");
            }
            catch (Exception )
            {
                TempData["a"] = "data doesn't stored !!";
                return View();

            }
           
        }

        public IActionResult DeleteCustomer(int id)
        {
            var cus = ctx.Customers.Find(id);
            var customer = ctx.Customers.FirstOrDefault(x => x.Id == id);
            var customer1 = ctx.Customers.SingleOrDefault(x => x.Id == id);
            var customer3 = ctx.Customers.First(x => x.Id == id);
            var customer4 = ctx.Customers.Where(x => x.Id==id).ToList();
            ctx.Customers.Remove(cus);
            ctx.SaveChanges();
            return RedirectToAction("ReadCustomer");


        }

        public IActionResult TruncateCustomer()
        {
            var customer = ctx.Customers.ToList();

            ctx.Customers.RemoveRange(customer);
            ctx.SaveChanges();
            return RedirectToAction("ReadCustomer");
        }

 
       
    }

}
