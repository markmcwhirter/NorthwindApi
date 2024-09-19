
public class ProductQueryHandler : IRequestHandler<GetProductByIdQuery, NorthwindApi.Models.Product>
{
    private static readonly ConcurrentDictionary<int, NorthwindApi.Models.Product> Products = new();

    private readonly IProductRepository _productRepository;

    public ProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<NorthwindApi.Models.Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {

        DB.Product? dbresult = await _productRepository.GetByIdAsync(request.Id);


        if (dbresult is null)
            return null;

        return new NorthwindApi.Models.Product { Id = dbresult.ProductId, Name = dbresult.ProductName, Price = dbresult.UnitPrice ?? 0 };

    }

}
