using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models.Entites
{
    public class ProductDBContext:DbContext
    {
     

        public ProductDBContext( DbContextOptions options) : base(options)
        {
        }
       
        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }
}
