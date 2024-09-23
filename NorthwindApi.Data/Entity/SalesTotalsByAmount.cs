namespace NorthwindApi.Data.Entity;


public class SalesTotalsByAmountConfiguration : IEntityTypeConfiguration<DB.SalesTotalsByAmount>
{
    public void Configure(EntityTypeBuilder<DB.SalesTotalsByAmount> entity)
    {
        entity
            .HasNoKey()
            .ToView("Sales Totals by Amount");

        entity.Property(e => e.CompanyName).HasMaxLength(40);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.SaleAmount).HasColumnType("money");
        entity.Property(e => e.ShippedDate).HasColumnType("datetime");
    }
}

