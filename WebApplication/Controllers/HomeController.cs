using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
      //  [ResponseCache(VaryByHeader ="User-Agent",Duration =30)]
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public ActionResult Index()
        {
            List<User> obj = new List<User>();
            obj.Add(new User() { id=101,Name="Siddhi"});
            obj.Add(new User() { id = 102, Name = "Sayali" });
            obj.Add(new User() { id = 103, Name = "Trupti" });
            obj.Add(new User() { id = 104, Name = "Chaitrali" });

            ViewData["UserInfo"] = obj;

            ViewBag.obj = obj;

            TempData["UserInfo"] = obj;

            ViewBag.Dt = DateTime.Now.ToString("MM/yy hh:mm:ss");
            return View();
        }
        public FileContentResult FileContentEx()
        {
            var pdf = System.IO.File.ReadAllBytes("wwwroot/Assignments.pdf");
            return new FileContentResult(pdf,"application/pdf");
        }
        public ViewResult ViewResultEx()
        {
            return View();
        }

        public JsonResult JsonResultEx()
        {
            string[] fruits = { "apple", "mango" };
            return Json(fruits);
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
