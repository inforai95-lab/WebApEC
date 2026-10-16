using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApEC.Models;

namespace WebApEC.Controllers
{
    public class ProductController : Controller
    {
        private readonly Iproductservice _iproductService;
        public ProductController(Iproductservice iproductservice)
        {
            _iproductService = iproductservice;
        }
        public async Task<IActionResult> Index()
        {
            var product = await _iproductService.GetProduct();
            return View(product);
        }
    }
}
