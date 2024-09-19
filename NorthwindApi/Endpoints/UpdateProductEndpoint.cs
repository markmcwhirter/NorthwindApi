
public class UpdateProductEndpoint : Endpoint<UpdateProductCommand, bool>
{
    private readonly IMediator _mediator;

    public UpdateProductEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Put("/api/product/{id:int}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateProductCommand req, CancellationToken ct)
    {
        if (Route<int>("id") != req.Id)
        {
            ThrowError("Product ID mismatch.");
        }

        var result = await _mediator.Send(req, ct);
        if (!result)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        await SendNoContentAsync(ct);
    }
}
