public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;
