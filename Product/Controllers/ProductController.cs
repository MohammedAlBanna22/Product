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

        [HttpGet]
        public IActionResult GetProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Product()
        {
            //var pageSize = int.Parse(Request.Form["length"]);
            //var skipe = int.Parse(Request.Form["start"]);
            //var search = Request.Form["search[value]"];
            //var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            //var sortDirecion = Request.Form["order[0][dir]"];

            //IQueryable<AppUser> users = _user.Users.Where(x => x.NameRole == "User").AsQueryable();
            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortDirecion)))
            //{
            //    users = users.OrderBy(string.Concat(sortColumn, " ", sortDirecion));
            //}

            //users = users.Where(x => string.IsNullOrEmpty(search) ? true :
            //x.FirstName.Contains(search) || x.LastName.Contains(search));
            //var data = await users.Skip(skipe).Take(pageSize).ToListAsync();
            //var recordsTotal = users.Count();
            //var jsonData = new { recordsFiltered = recordsTotal, recordsTotal, data };

            //return Ok(jsonData);






            var pageSize = int.Parse(Request.Form["length"]);
            var skipe = int.Parse(Request.Form["start"]);
            var search = Request.Form["search[value]"];
            var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            var sortDirecion = Request.Form["order[0][dir]"];

            var products = _rep.GetProducts().Skip(skipe).Take(pageSize);
            var recordTotal = _rep.GetProducts().Count();
            var jsonData = new { recordsFiltered = recordTotal, recordTotal, data = products };
            return Ok(jsonData);
        }

    }
}
