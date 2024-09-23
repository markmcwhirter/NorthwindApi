namespace NorthwindApi.Data.Entity;


public class QuarterlyOrderConfiguration : IEntityTypeConfiguration<DB.QuarterlyOrder>
{
    public void Configure(EntityTypeBuilder<DB.QuarterlyOrder> entity)
    {
        entity
            .HasNoKey()
            .ToView("Quarterly Orders");

        entity.Property(e => e.City).HasMaxLength(15);
        entity.Property(e => e.CompanyName).HasMaxLength(40);
        entity.Property(e => e.Country).HasMaxLength(15);
        entity.Property(e => e.CustomerId)
            .HasMaxLength(5)
            .IsFixedLength()
            .HasColumnName("CustomerID");
    }
}

