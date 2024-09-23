namespace NorthwindApi.Data.Entity;


public class ProductsByCategoryConfiguration : IEntityTypeConfiguration<DB.ProductsByCategory>
{
    public void Configure(EntityTypeBuilder<DB.ProductsByCategory> entity)
    {
        entity
            .HasNoKey()
            .ToView("Products by Category");

        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
    }
}

