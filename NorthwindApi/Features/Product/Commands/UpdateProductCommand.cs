public record UpdateProductCommand(int Id, string Name, decimal Price) : IRequest<bool>;
