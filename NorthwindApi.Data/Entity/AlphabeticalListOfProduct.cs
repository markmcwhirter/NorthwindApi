using Microsoft.EntityFrameworkCore;

namespace NorthwindApi.Data.Entity;


public class AlphabeticalListOfProductConfiguration : IEntityTypeConfiguration<DB.AlphabeticalListOfProduct>
{
    public void Configure(EntityTypeBuilder<DB.AlphabeticalListOfProduct> entity)
    {

        entity
            .HasNoKey()
            .ToView("Alphabetical list of products");

        entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.UnitPrice).HasColumnType("money");
    }
}

