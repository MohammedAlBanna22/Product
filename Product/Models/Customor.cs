using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class Customor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int age { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public IFormFile image { get; set; }
        
    }
}
