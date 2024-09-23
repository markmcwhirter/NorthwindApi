namespace NorthwindApi.Data.Entity;


public class RegionConfiguration : IEntityTypeConfiguration<DB.Region>
{
    public void Configure(EntityTypeBuilder<DB.Region> entity)
    {
        entity.HasKey(e => e.RegionId).IsClustered(false);

        entity.ToTable("Region");

        entity.Property(e => e.RegionId)
            .ValueGeneratedNever()
            .HasColumnName("RegionID");
        entity.Property(e => e.RegionDescription)
            .HasMaxLength(50)
            .IsFixedLength();
    }
}

