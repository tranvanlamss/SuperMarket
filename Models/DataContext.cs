﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SuperMarket.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("SuperMarket")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        

    }
}