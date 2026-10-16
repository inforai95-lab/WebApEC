using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApEC.Models;

namespace WebApEC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
     
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/List")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GetEmployees()
        {
            var list = new List<Employee1>()
    {
        new Employee1 { Id = 1, Name = "Rahul", Salary = 50000 },
        new Employee1 { Id = 2, Name = "Amit", Salary = 60000 },
        new Employee1 { Id = 3, Name = "John", Salary = 70000 }
    };

            return Json(list);
        }
        [HttpPost]
        public IActionResult SaveData(string Name)
        {
            return Content("Welcome " + Name);
        }
    }
}
