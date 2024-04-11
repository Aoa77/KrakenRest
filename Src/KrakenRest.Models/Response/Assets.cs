namespace KrakenRest.Models.Response;

public sealed class Assets : Dictionary<string, Asset>, IResponseData
{
    public Type? RequestType => typeof(Request.Asset);
}

/// <summary>
/// Asset Info
/// </summary>
public sealed class Asset
{
    /// <summary>
    /// Asset Class
    /// </summary>
    public string aclass { get; set; }

    /// <summary>
    /// Alternate name
    /// </summary>
    public string altname { get; set; }

    /// <summary>
    /// Scaling decimal places for record keeping
    /// </summary>
    public int decimals { get; set; }

    /// <summary>
    /// Scaling decimal places for output display
    /// </summary>
    public int display_decimals { get; set; }

    /// <summary>
    /// Valuation as margin collateral (if applicable)
    /// </summary>
    public int collateral_value { get; set; }

    /// <summary>
    /// Status of asset. Possible values: enabled, deposit_only, withdrawal_only, funding_temporarily_disabled.
    /// </summary>
    public string status { get; set; }
}
