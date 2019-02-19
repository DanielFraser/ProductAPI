using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }

    
    public class MyContext : DbContext
    {
        public MyContext() : base("Program") { }
        public virtual DbSet<Product> Products { get; set; }
    }
}