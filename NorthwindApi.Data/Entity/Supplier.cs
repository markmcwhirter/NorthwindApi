﻿namespace NorthwindApi.Data.Entity;


public class SupplierConfiguration : IEntityTypeConfiguration<DB.Supplier>
{
    public void Configure(EntityTypeBuilder<DB.Supplier> entity)
    {
        entity.HasIndex(e => e.CompanyName, "CompanyName");

        entity.HasIndex(e => e.PostalCode, "PostalCode");

        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.Address).HasMaxLength(60);
        entity.Property(e => e.City).HasMaxLength(15);
        entity.Property(e => e.CompanyName).HasMaxLength(40);
        entity.Property(e => e.ContactName).HasMaxLength(30);
        entity.Property(e => e.ContactTitle).HasMaxLength(30);
        entity.Property(e => e.Country).HasMaxLength(15);
        entity.Property(e => e.Fax).HasMaxLength(24);
        entity.Property(e => e.HomePage).HasColumnType("ntext");
        entity.Property(e => e.Phone).HasMaxLength(24);
        entity.Property(e => e.PostalCode).HasMaxLength(10);
        entity.Property(e => e.Region).HasMaxLength(15);
    }
}

