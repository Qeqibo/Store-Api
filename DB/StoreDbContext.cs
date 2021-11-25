using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DB
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
        }*/
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShopBasket> ShopBaskets { get; set; }
    }
}
