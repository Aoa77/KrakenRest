namespace KrakenRest.Models.Request;

public sealed class Asset : RequestQuery
{
    public Asset()
    {
        Optional = new[] { "asset", "aclass" };
    }
}
