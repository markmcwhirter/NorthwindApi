namespace NorthwindApi.Data;


public class ProductRepository : Repository<DB.Product>, IProductRepository
{
    readonly NorthwindContext _context;

    public ProductRepository(NorthwindContext context) : base(context)
    {
        _context = context;
    }

    public async Task<DB.Product> GetByNameAsync(string name) =>
        await _context.Products.FirstOrDefaultAsync(p => p.ProductName == name);
    

    public async Task<IEnumerable<DB.Product>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice) =>
        await _context.Products
            .Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice)
            .ToListAsync();
    
}

