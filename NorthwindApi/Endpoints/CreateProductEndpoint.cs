
public class CreateProductEndpoint : Endpoint<CreateProductCommand, int>
{
    private readonly IMediator _mediator;

    public CreateProductEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Post("/api/product");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateProductCommand req, CancellationToken ct)
    {
        var productId = await _mediator.Send(req, ct);
        await SendAsync(productId, cancellation: ct);
    }
}
