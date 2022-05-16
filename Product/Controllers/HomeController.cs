using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using Product.Models;
using Product.Models.Entites;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;


namespace Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductDBContext _productDBContext;

        public HomeController(ILogger<HomeController> logger, ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.addproduct = _productDBContext.Products.ToList();
            ViewBag.addclient = _productDBContext.appUsers.ToList();
            ViewBag.addblog = _productDBContext.Blogs.ToList();

            return View();
        }


        public IActionResult Productslist( int? page)
        {
            var pageNumber = page ?? 1;
            //int pageSize =4 ;
            var item = _productDBContext.Products.ToList();
           // var item =  _productDBContext.Products.ToPagedList(pageNumber, pageSize).ToList();
          //  ViewData["product"] = _productDBContext.Products.ToPagedList(pageNumber, pageSize);
          //ViewBag.products = _productDBContext.Products.ToPagedList(pageNumber, pageSize).ToList();
            return View(item);

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
