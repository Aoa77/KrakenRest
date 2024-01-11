using KrakenRest.Models;
using RestSharp;
namespace KrakenRest.NetCore;

public sealed class RestRouter : EndpointRouter
{
    private readonly IRestClient _client;
    private readonly Configuration _config;

    public RestRouter(IEndpointRouteBuilder app,
        IRestClient client, Configuration config) : base(app)
    {
        _client = client;
        _config = config;
    }

    public void MapGet<T>() where T : IResponseData
    {
        var route = typeof(T).Name;
        _app.MapGet($@"/{route}", (HttpContext ctx) =>
        {
            ExecuteGet<T>(ctx, route).Wait();
        })
        .WithName("Get"  + route)
        .WithOpenApi();
    }

    private async Task ExecuteGet<T>(HttpContext ctx,
        string route) where T : IResponseData
    {
        var request
            = new RestRequest(route, Method.Get);

        ctx.Request.Query
            .ToList()
            .ForEach(q => request.AddQueryParameter(
                q.Key, q.Value));

        if (_config.StrongModels)
        {
            await ExecuteGet<T>(ctx, request: request);
            return;
        }

        await ExecuteGet<object>(ctx, request: request);
    }

    private async Task ExecuteGet<T>(HttpContext ctx,
        RestRequest request)
    {
        var response = await
            _client.ExecuteAsync<ResponseData<T>>(request);

        ctx.Response.StatusCode = (int)response.StatusCode;

        await ctx.Response.WriteAsJsonAsync(
            value: response.Data,
            type: typeof(T),
            options: new() { WriteIndented = _config.Debug });

    }
}
