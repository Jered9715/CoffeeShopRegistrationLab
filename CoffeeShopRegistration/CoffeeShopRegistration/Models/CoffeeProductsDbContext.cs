using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CoffeeShopRegistration.Models;

namespace CoffeeShopRegistration.Models;

public partial class CoffeeProductsDbContext : DbContext
{
    public CoffeeProductsDbContext()
    {
    }

    public CoffeeProductsDbContext(DbContextOptions<CoffeeProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC070896DC05");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
