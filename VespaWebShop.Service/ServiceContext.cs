﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VespaWebShop.Service.Models;

namespace VespaWebShop.Service
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(): base("VespaWebShop")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
