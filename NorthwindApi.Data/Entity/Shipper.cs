namespace NorthwindApi.Data.Entity;


public class ShipperConfiguration : IEntityTypeConfiguration<DB.Shipper>
{
    public void Configure(EntityTypeBuilder<DB.Shipper> entity)
    {
        entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
        entity.Property(e => e.CompanyName).HasMaxLength(40);
        entity.Property(e => e.Phone).HasMaxLength(24);
    }
}

