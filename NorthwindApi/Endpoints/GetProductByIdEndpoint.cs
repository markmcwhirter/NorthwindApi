
public class GetProductByIdEndpoint : Endpoint<GetProductByIdQuery, NorthwindApi.Models.Product>
{
    private readonly IMediator _mediator;

    public GetProductByIdEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("/api/product/{id:int}");        
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetProductByIdQuery req, CancellationToken ct)
    {

        var product = await _mediator.Send(req, ct);
        if (product is null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        await SendAsync(product, cancellation: ct);
    }
}
