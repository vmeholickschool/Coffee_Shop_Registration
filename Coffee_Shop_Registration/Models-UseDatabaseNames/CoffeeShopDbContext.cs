using System;
using System.Collections.Generic;
using Coffee_Shop_Registration.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Registration.Models
{
    public partial class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext()
        {
        }

        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                _ = optionsBuilder.UseSqlServer("Server=2NTJ6J3\\MSSQLSERVER01;Database=CoffeeShopDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Product>((Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product>>)(entity =>
            {
                _ = entity.HasKey(e => e.Id).HasName("PK__Products__3214EC272C79B79B");

                _ = entity.Property(e => e.Id).HasColumnName("ID");
                _ = entity.Property<string>(e => e.Category).HasMaxLength(50);
                _ = entity.Property<string>(e => (string)e.Name).HasMaxLength(100);
                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            }));

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
