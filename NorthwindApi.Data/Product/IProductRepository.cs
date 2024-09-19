namespace NorthwindApi.Data;


public interface IProductRepository : IRepository<NorthwindApi.Data.Models.Product>
{
    Task<NorthwindApi.Data.Models.Product> GetByNameAsync(string name);
    Task<IEnumerable<NorthwindApi.Data.Models.Product>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice);
}

