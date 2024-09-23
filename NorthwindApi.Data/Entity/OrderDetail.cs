namespace NorthwindApi.Data.Entity;


public class OrderDetailConfiguration : IEntityTypeConfiguration<DB.OrderDetail>
{
    public void Configure(EntityTypeBuilder<DB.OrderDetail> entity)
    {
        entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK_Order_Details");

        entity.ToTable("Order Details");

        entity.HasIndex(e => e.OrderId, "OrderID");

        entity.HasIndex(e => e.OrderId, "OrdersOrder_Details");

        entity.HasIndex(e => e.ProductId, "ProductID");

        entity.HasIndex(e => e.ProductId, "ProductsOrder_Details");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.Quantity).HasDefaultValue((short)1);
        entity.Property(e => e.UnitPrice).HasColumnType("money");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
            .HasForeignKey(d => d.OrderId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Order_Details_Orders");

        entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
            .HasForeignKey(d => d.ProductId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Order_Details_Products");

    }
}

