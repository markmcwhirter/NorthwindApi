namespace NorthwindApi.Data.Entity;


public class CustomerAndSuppliersByCityConfiguration : IEntityTypeConfiguration<DB.CustomerAndSuppliersByCity>
{
    public void Configure(EntityTypeBuilder<DB.CustomerAndSuppliersByCity> entity)
    {
        entity
            .HasNoKey()
            .ToView("Customer and Suppliers by City");

        entity.Property(e => e.City).HasMaxLength(15);
        entity.Property(e => e.CompanyName).HasMaxLength(40);
        entity.Property(e => e.ContactName).HasMaxLength(30);
        entity.Property(e => e.Relationship)
            .HasMaxLength(9)
            .IsUnicode(false);
    }
}

