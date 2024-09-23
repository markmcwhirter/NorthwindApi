namespace NorthwindApi.Data.Entity;


public class CategoryConfiguration : IEntityTypeConfiguration<DB.Category>
{
    public void Configure(EntityTypeBuilder<DB.Category> entity)
    {
        entity.HasIndex(e => e.CategoryName, "CategoryName");

        entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        entity.Property(e => e.CategoryName).HasMaxLength(15);
        entity.Property(e => e.Description).HasColumnType("ntext");
        entity.Property(e => e.Picture).HasColumnType("image");
    }
}

