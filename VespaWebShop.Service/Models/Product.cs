﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VespaWebShop.Service.Models
{
    public class Product
    {

        public long ProductId { get; set; }

        public string ProductNumber { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public float Price { get; set; }

        public int Stock { get; set; }

        public IList<Tag> Tags { get; set; }

        public IList<Image> Images { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}