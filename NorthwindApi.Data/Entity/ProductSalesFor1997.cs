namespace NorthwindApi.Data.Entity;


public class ProductSalesFor1997Configuration : IEntityTypeConfiguration<DB.ProductSalesFor1997>
{
    public void Configure(EntityTypeBuilder<DB.ProductSalesFor1997> entity)
    {
        entity
            .HasNoKey()
            .ToView("Product Sales for 1997");

        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.ProductSales).HasColumnType("money");
    }
}

