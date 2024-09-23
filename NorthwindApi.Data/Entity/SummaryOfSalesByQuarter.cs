namespace NorthwindApi.Data.Entity;


public class SummaryOfSalesByQuarterConfiguration : IEntityTypeConfiguration<DB.SummaryOfSalesByQuarter>
{
    public void Configure(EntityTypeBuilder<DB.SummaryOfSalesByQuarter> entity)
    {
        entity
            .HasNoKey()
            .ToView("Summary of Sales by Quarter");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        entity.Property(e => e.Subtotal).HasColumnType("money");
    }
}

