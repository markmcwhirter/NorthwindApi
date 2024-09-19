namespace NorthwindApi.Data;


public class ProductRepository : Repository<DB.Product>, IProductRepository
{
    readonly IDbContextFactory<NorthwindContext> _contextFactory;

    public ProductRepository(IDbContextFactory<NorthwindContext> contextFactory) : base(contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<DB.Product> GetByNameAsync(string name)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Products.FirstOrDefaultAsync(p => p.ProductName == name);
    }

    public async Task<IEnumerable<DB.Product>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Products
            .Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice)
            .ToListAsync();
    }
}

