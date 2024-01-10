namespace KrakenRest.Models.Response;

public sealed class Assets : Dictionary<string, Asset>, IResponseData
{
    public Type? RequestType { get; } = typeof(Request.Asset);
}

public sealed class Asset
{
    public string aclass { get; set; }
    public string altname { get; set; }
    public int decimals { get; set; }
    public int display_decimals { get; set; }
    public string status { get; set; }
}
