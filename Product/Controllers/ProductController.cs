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
        private readonly ProductDBContext _context;
        public ProductController(IProductRepository rep, ProductDBContext context)
        {
            _rep=rep;
            _context = context;
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

        [HttpGet]
        public IActionResult GetProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Product()
        {
            var pageSize = int.Parse(Request.Form["length"]);
            var skipe = int.Parse(Request.Form["start"]);
            var search = Request.Form["search[value]"];
            var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            var sortDirecion = Request.Form["order[0][dir]"];

            IQueryable < Products > productview = _context.Products.Where(x => string.IsNullOrEmpty(search) ? true :
            x.productName.Contains(search) ).AsQueryable();


            var products = productview.Skip(skipe).Take(pageSize);
            var recordTotal = _rep.GetProducts().Count();
            var jsonData = new { recordsFiltered = recordTotal, recordTotal, data = products };
            return Ok(jsonData);
        }


        public IActionResult GetUsers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Users()
        {
            var pageSize = int.Parse(Request.Form["length"]);
            var skipe = int.Parse(Request.Form["start"]);
            var search = Request.Form["search[value]"];
            var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            var sortDirecion = Request.Form["order[0][dir]"];

            IQueryable<appUsers> userview = _context.appUsers.Where(x => string.IsNullOrEmpty(search) ? true :
            x.Name.Contains(search)).AsQueryable();


            var users = userview.Skip(skipe).Take(pageSize);
            var recordTotal = _rep.GetUsers().Count();
            var jsonData = new { recordsFiltered = recordTotal, recordTotal, data = users };
            return Ok(jsonData);
        }
    }
}
