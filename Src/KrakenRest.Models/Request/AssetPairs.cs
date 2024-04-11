namespace KrakenRest.Models.Request;

public sealed class AssetPairs : RequestQuery
{
    public AssetPairs()
    {
        Optional = new[] { "pair", "info" };
    }
}
