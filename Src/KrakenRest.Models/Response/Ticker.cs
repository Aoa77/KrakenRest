namespace KrakenRest.Models.Response;

public sealed class Ticker : Dictionary<string, AssetTickerInfo>, IResponseData
{
    public Type? RequestType => typeof(Request.Ticker);
}

/// <summary>
/// Asset Ticker Info
/// </summary>
public sealed class AssetTickerInfo
{
    /// <summary>
    /// Ask [<price>, <whole lot volume>, <lot volume>]
    /// </summary>
    public string[] a { get; set; }

    /// <summary>
    /// Bid [<price>, <whole lot volume>, <lot volume>]
    /// </summary>
    public string[] b { get; set; }

    /// <summary>
    /// Last trade closed [<price>, <lot volume>]
    /// </summary>
    public string[] c { get; set; }

    /// <summary>
    /// Volume [<today>, <last 24 hours>]
    /// </summary>
    public string[] v { get; set; }

    /// <summary>
    /// Volume weighted average price [<today>, <last 24 hours>]
    /// </summary>
    public string[] p { get; set; }

    /// <summary>
    /// Number of trades [<today>, <last 24 hours>]
    /// </summary>
    public int[] t { get; set; }

    /// <summary>
    /// Low [<today>, <last 24 hours>]
    /// </summary>
    public string[] l { get; set; }

    /// <summary>
    /// High [<today>, <last 24 hours>]
    /// </summary>
    public string[] h { get; set; }

    /// <summary>
    /// Today's opening price
    /// </summary>
    public string o { get; set; }

}


