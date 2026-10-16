using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApEC.Models;

namespace WebApEC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext Dbcontext)
        {
            _context = Dbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var employee = await _context.Employees.ToListAsync();
            return View(employee);
        
        
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitData(Employee employees)
        {
            if (ModelState.IsValid)
            {
                await _context.Employees.AddAsync(employees);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Employee saved successfully.";

                return RedirectToAction("Index");
            }

            return View("Create", employees);
        }
    }
}
