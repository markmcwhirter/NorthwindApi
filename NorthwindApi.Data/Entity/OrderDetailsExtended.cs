namespace NorthwindApi.Data.Entity;


public class OrderDetailsExtendedConfiguration : IEntityTypeConfiguration<DB.OrderDetailsExtended>
{
    public void Configure(EntityTypeBuilder<DB.OrderDetailsExtended> entity)
    {
        entity
            .HasNoKey()
            .ToView("Order Details Extended");

        entity.Property(e => e.ExtendedPrice).HasColumnType("money");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.ProductName).HasMaxLength(40);
        entity.Property(e => e.UnitPrice).HasColumnType("money");

    }
}

