using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Product.Models;
using Product.Models.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Rebository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDBContext _context;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public ProductRepository(ProductDBContext context, IMapper mapper, IWebHostEnvironment WebHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _WebHostEnvironment = WebHostEnvironment;
        }
        public Products AddProduct(FoodProduct viewproduct)
        {
            //Products newProduct = new Products();
            //if (foodproduct!= null)
            //{
            var url = addphoto(viewproduct.image, "pic/products/");
            viewproduct.imageUrl = url;
            var newProduct = _mapper.Map<Products>(viewproduct);
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;


        }

        public appUsers ADDUsers(Customor customor)
        {
            var url = addphoto(customor.image, "pic/Users/");
            customor.imageUrl = url;
            var newUser = _mapper.Map<appUsers>(customor);
            _context.appUsers.Add(newUser);
            _context.SaveChanges();
            return newUser;

        }
        
        public Blogs AddBlog(BlogView blogView)
        {
            var blog = _mapper.Map<Blogs>(blogView);
            var imgurl = addphoto(blogView.image, "pic/blogs/");
            blog.imageUrl = imgurl;
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return blog;
            
        }


        //extention in formfile


        public  string addphoto(IFormFile img ,string filePath)
        {
            string folder = filePath ; 
            folder += Guid.NewGuid().ToString() + "_" + img.FileName;
            string imageUrl = "/" + folder;
            string serverfolder = Path.Combine(_WebHostEnvironment.WebRootPath, folder);
           img.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            return imageUrl;
        }
        public string addphotoByOBJ(FoodProduct product, string filePath)
        {
            string folder = filePath;
            folder += Guid.NewGuid().ToString() + "_" + product.image.FileName;
            product.imageUrl = "/" + folder;
            string serverfolder = Path.Combine(_WebHostEnvironment.WebRootPath, folder);
            product.image.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            return product.imageUrl;
        }
      

        public List<Products> GetProducts()
        {
            var products = _context.Products.ToList();
            return (products);
        }
        public List<appUsers> GetUsers()
        {
            var users = _context.appUsers.ToList();
            return (users);
        }

        public List<Blogs> GetBlogs()
        {
            var Blogs = _context.Blogs.ToList();
            return (Blogs);
        }
   

    }
}
