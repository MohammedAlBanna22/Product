﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Models
{
    public class FoodProduct
    {
        
        public int id { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public DateTime productDate { get; set; }
        public DateTime EpireDate { get; set; }
        public int price { get; set; }
        public string imageUrl { get; set; }
        public IFormFile image { get; set; }
    }
}
