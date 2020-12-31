using BMES_REST_API.Models.Address;
using BMES_REST_API.Models.Cart;
using BMES_REST_API.Models.Product;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using BmesRestApi.Models.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Database
{
    public class BmesDbContext: DbContext
    {
        public BmesDbContext(DbContextOptions<BmesDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
