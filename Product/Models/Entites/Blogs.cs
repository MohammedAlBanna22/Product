using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models.Entites
{
    public class Blogs
    {

        public int id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public string imageUrl { get; set; }
    }
}
