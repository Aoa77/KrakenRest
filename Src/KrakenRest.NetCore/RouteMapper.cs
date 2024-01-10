using KrakenRest.Models.Response;
using RestSharp;
namespace KrakenRest.NetCore;

public static class RouteMapper
{
    public static RestRouter MapRest(
        this IEndpointRouteBuilder app,
        IRestClient client, Configuration config)
    {
        var router = new RestRouter(app, client, config);

        router.MapGet<Time>();
        router.MapGet<SystemStatus>();
        router.MapGet<Assets>();
        router.MapGet<AssetPairs>();
        router.MapGet<Ticker>();
        router.MapGet<OHLC>();
        router.MapGet<Depth>();
        router.MapGet<Trades>();
        router.MapGet<Spread>();

        return router;
    }
}
