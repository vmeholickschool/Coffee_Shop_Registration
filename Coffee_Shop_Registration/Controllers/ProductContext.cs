// ProductContext.cs
using Coffee_Shop_Registration.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Registration.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
