namespace NorthwindApi.Data.Entity;


public class TerritoryConfiguration : IEntityTypeConfiguration<DB.Territory>
{
    public void Configure(EntityTypeBuilder<DB.Territory> entity)
    {
        entity.HasKey(e => e.TerritoryId).IsClustered(false);

        entity.Property(e => e.TerritoryId)
            .HasMaxLength(20)
            .HasColumnName("TerritoryID");
        entity.Property(e => e.RegionId).HasColumnName("RegionID");
        entity.Property(e => e.TerritoryDescription)
            .HasMaxLength(50)
            .IsFixedLength();

        entity.HasOne(d => d.Region).WithMany(p => p.Territories)
            .HasForeignKey(d => d.RegionId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Territories_Region");
    }
}

