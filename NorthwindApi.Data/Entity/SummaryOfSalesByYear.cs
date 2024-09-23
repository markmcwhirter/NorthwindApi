namespace NorthwindApi.Data.Entity;


public class SummaryOfSalesByYearConfiguration : IEntityTypeConfiguration<DB.SummaryOfSalesByYear>
{
    public void Configure(EntityTypeBuilder<DB.SummaryOfSalesByYear> entity)
    {
        entity
            .HasNoKey()
            .ToView("Summary of Sales by Year");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        entity.Property(e => e.Subtotal).HasColumnType("money");
    }
}

