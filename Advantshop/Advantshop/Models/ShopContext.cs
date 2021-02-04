using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Advantshop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}