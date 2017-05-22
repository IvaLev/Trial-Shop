﻿using System.Collections.Generic;

namespace Shop.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<ProductModel> Products { get; set; } 
    }
}
