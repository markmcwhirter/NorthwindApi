namespace NorthwindApi.Data.Entity;


public class CategorySalesFor1997Configuration : IEntityTypeConfiguration<DB.CategorySalesFor1997>
{
    public void Configure(EntityTypeBuilder<DB.CategorySalesFor1997> entity)
    {
        entity
            .HasNoKey()
            .ToView("Category Sales for 1997");

        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.CategorySales).HasColumnType("money");
    }
}

