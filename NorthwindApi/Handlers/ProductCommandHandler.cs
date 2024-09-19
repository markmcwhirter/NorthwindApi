
public class ProductCommandHandler :
    IRequestHandler<CreateProductCommand, int>,
    IRequestHandler<UpdateProductCommand, bool>
{
    private static readonly ConcurrentDictionary<int, NorthwindApi.Data.Models.Product> Products = new();

    private readonly IProductRepository _productRepository;

    public ProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {

        var id = await _productRepository.AddAsync(new NorthwindApi.Data.Models.Product
        { 
             ProductName = request.Name,
             UnitPrice = request.Price
        });
        return id;
    }

    public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        await _productRepository.UpdateAsync(new NorthwindApi.Data.Models.Product
        {
            ProductName = request.Name,
            UnitPrice = request.Price
        });

        return true;
    }
}
