﻿namespace NorthwindApi.Data.Entity;


public class ProductConfiguration : IEntityTypeConfiguration<DB.Product>
{
    public void Configure(EntityTypeBuilder<DB.Product> entity)
    {
        entity.HasIndex(e => e.CategoryId, "CategoriesProducts");

        entity.HasIndex(e => e.CategoryId, "CategoryID");

        entity.HasIndex(e => e.ProductName, "ProductName");

        entity.HasIndex(e => e.SupplierId, "SupplierID");

        entity.HasIndex(e => e.SupplierId, "SuppliersProducts");

        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
        entity.Property(e => e.ReorderLevel).HasDefaultValue((short)0);
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.UnitPrice)
                .HasDefaultValue(0m)
                .HasColumnType("money");
        entity.Property(e => e.UnitsInStock).HasDefaultValue((short)0);
        entity.Property(e => e.UnitsOnOrder).HasDefaultValue((short)0);

        entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

        entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
    }
}

