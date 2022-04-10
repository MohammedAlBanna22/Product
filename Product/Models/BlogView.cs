using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class BlogView
    {
        public string title  { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public string  imageUrl { get; set; }
        public IFormFile image { get; set; }
    }
}
