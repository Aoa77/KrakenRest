namespace KrakenRest.NetCore;

public abstract class EndpointRouter
{
    protected readonly IEndpointRouteBuilder _app;

    protected EndpointRouter(IEndpointRouteBuilder app)
    {
        _app = app;
    }
}
