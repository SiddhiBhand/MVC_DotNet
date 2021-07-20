using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilterMVC.Controllers
{
    public class FilterTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize("Read")]
        public IActionResult Read()
        {
            return View();
        }
        [Authorize("Write")]
        public IActionResult Write()
        {
            return View();
        }
        [CacheResource]
        public IActionResult CacheTest()
        {
            return Content("This cantent was generated at "+DateTime.Now);
        }

        [ValidateModel]
        public IActionResult ActionFilterTest(string name)
        {
            return View();
        }
        
        public IActionResult GenerateError()
        {
            throw new NotImplementedException();
        }
    }
}
