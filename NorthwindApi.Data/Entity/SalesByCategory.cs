namespace NorthwindApi.Data.Entity;


public class SalesByCategoryConfiguration : IEntityTypeConfiguration<DB.SalesByCategory>
{
    public void Configure(EntityTypeBuilder<DB.SalesByCategory> entity)
    {
        entity
            .HasNoKey()
            .ToView("Sales by Category");

        entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.ProductSales).HasColumnType("money");
    }
}

