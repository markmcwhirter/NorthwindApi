namespace NorthwindApi.Data.Entity;


public class ProductsAboveAveragePriceConfiguration : IEntityTypeConfiguration<DB.ProductsAboveAveragePrice>
{
    public void Configure(EntityTypeBuilder<DB.ProductsAboveAveragePrice> entity)
    {
        entity
            .HasNoKey()
            .ToView("Products Above Average Price");

        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.UnitPrice).HasColumnType("money");
    }
}

