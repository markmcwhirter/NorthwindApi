namespace NorthwindApi.Data.Entity;


public class CurrentProductListConfiguration : IEntityTypeConfiguration<DB.CurrentProductList>
{
    public void Configure(EntityTypeBuilder<DB.CurrentProductList> entity)
    {
        entity
            .HasNoKey()
            .ToView("Current Product List");

        entity.Property(e => e.ProductId)
            .ValueGeneratedOnAdd()
            .HasColumnName("ProductID");
        entity.Property(e => e.ProductName).HasMaxLength(40);
    }
}

