using GRT_ASSIIGNMENT.Models;
using Microsoft.EntityFrameworkCore;

namespace GRT_ASSIIGNMENT.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

       
        public  DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }

    }
}
