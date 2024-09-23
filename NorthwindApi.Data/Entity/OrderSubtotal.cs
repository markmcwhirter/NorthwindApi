namespace NorthwindApi.Data.Entity;


public class OrderSubtotalConfiguration : IEntityTypeConfiguration<DB.OrderSubtotal>
{
    public void Configure(EntityTypeBuilder<DB.OrderSubtotal> entity)
    {
        entity
            .HasNoKey()
            .ToView("Order Subtotals");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.Subtotal).HasColumnType("money");
    }
}

