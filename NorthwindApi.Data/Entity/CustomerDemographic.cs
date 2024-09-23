namespace NorthwindApi.Data.Entity;


public class CustomerDemographicConfiguration : IEntityTypeConfiguration<DB.CustomerDemographic>
{
    public void Configure(EntityTypeBuilder<DB.CustomerDemographic> entity)
    {
        entity.HasKey(e => e.CustomerTypeId).IsClustered(false);

        entity.Property(e => e.CustomerTypeId)
            .HasMaxLength(10)
            .IsFixedLength()
            .HasColumnName("CustomerTypeID");
        entity.Property(e => e.CustomerDesc).HasColumnType("ntext");
    }
}

