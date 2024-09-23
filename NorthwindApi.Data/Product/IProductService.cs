namespace NorthwindApi.Data;

public interface IProductService
{
    Task<IEnumerable<DB.Product>> GetAllProductsAsync();

    Task<DB.Product> GetProductByIdAsync(int id);

    Task<DB.Product> GetProductByNameAsync(string name);

    Task<IEnumerable<DB.Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice);

    Task AddProductAsync(DB.Product product);

    Task UpdateProductAsync(DB.Product product);

    Task DeleteProductAsync(int id);
}
