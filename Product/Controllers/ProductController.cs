using Microsoft.AspNetCore.Mvc;
using Product.Models;
using Product.Models.Entites;
using Product.Rebository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _rep;
        public ProductController(IProductRepository rep)
        {
            _rep=rep;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FoodProduct product)
        {
             var Newproduct =_rep.AddProduct(product);
          
           
            return View();
        }

        public IActionResult AddUser()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(Customor user)
        {

            var NewUser = _rep.ADDUsers(user);
            return View();
        }

        public IActionResult AddBlog()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(BlogView blog)
        {
            var newBlog = _rep.AddBlog(blog);
            return View();
        }


    }
}
