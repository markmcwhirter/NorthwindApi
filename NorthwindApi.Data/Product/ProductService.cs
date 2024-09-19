namespace NorthwindApi.Data;

using DB= NorthwindApi.Data.Models;
public class ProductsService
{
    private readonly IProductRepository _productRepository;

    public ProductsService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<DB.Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<DB.Product> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task<DB.Product> GetProductByNameAsync(string name)
    {
        return await _productRepository.GetByNameAsync(name);
    }

    public async Task<IEnumerable<DB.Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        return await _productRepository.GetByPriceRangeAsync(minPrice, maxPrice);
    }

    public async Task AddProductAsync(DB.Product product)
    {
        await _productRepository.AddAsync(product);
    }

    public async Task UpdateProductAsync(DB.Product product)
    {
        await _productRepository.UpdateAsync(product);
    }

    public async Task DeleteProductAsync(int id)
    {
        await _productRepository.DeleteAsync(id);
    }
}
