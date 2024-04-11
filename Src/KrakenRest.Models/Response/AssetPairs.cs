namespace KrakenRest.Models.Response;

public sealed class AssetPairs : Dictionary<string, AssetPair>, IResponseData
{
    public Type? RequestType => typeof(Request.AssetPairs);
}


public class AssetPair
{
    /// <summary>
    /// Alternate pair name
    /// </summary>
    public string altname { get; set; }

    /// <summary>
    /// WebSocket pair name (if available)
    /// </summary>
    public string wsname { get; set; }

    /// <summary>
    /// Asset class of base component
    /// </summary>
    public string aclass_base { get; set; }

    /// <summary>
    /// Asset ID of base component
    /// </summary>
    public string @base { get; set; }

    /// <summary>
    /// Asset class of quote component
    /// </summary>
    public string aclass_quote { get; set; }

    /// <summary>
    /// Asset ID of quote component
    /// </summary>
    public string quote { get; set; }

    /// <summary>
    /// Volume lot size
    /// </summary>
    public string lot { get; set; }

    /// <summary>
    /// Scaling decimal places for pair
    /// </summary>
    public int pair_decimals { get; set; }

    /// <summary>
    /// Scaling decimal places for cost
    /// </summary>
    public int cost_decimals { get; set; }

    /// <summary>
    /// Scaling decimal places for volume
    /// </summary>
    public int lot_decimals { get; set; }

    /// <summary>
    /// Amount to multiply lot volume by to get currency volume 
    /// </summary>
    public int lot_multiplier { get; set; }

    /// <summary>
    /// Array of leverage amounts available when buying 
    /// </summary>
    public int[] leverage_buy { get; set; }

    /// <summary>
    /// Array of leverage amounts available when selling 
    /// </summary>
    public int[] leverage_sell { get; set; }

    /// <summary>
    /// Fee schedule array in <code >[&lt;volume&gt;, &lt;percent fee&gt;]</code > tuples 
    /// </summary>
    public IEnumerable<double[]> fees { get; set; }

    /// <summary>
    /// Maker fee schedule array in <code >[&lt;volume&gt;, &lt;percent fee&gt;]</code > tuples (if on maker/taker) 
    /// </summary>
    public IEnumerable<double[]> fees_maker { get; set; }

    /// <summary>
    /// Volume discount currency
    /// </summary>
    public string fee_volume_currency { get; set; }

    /// <summary>
    /// Margin call level
    /// </summary>
    public int margin_call { get; set; }

    /// <summary>
    /// Stop-out/liquidation margin level
    /// </summary>
    public int margin_stop { get; set; }

    /// <summary>
    /// Minimum order size (in terms of base currency) 
    /// </summary>
    public string ordermin { get; set; }

    /// <summary>
    /// Minimum order cost (in terms of quote currency) 
    /// </summary>
    public string costmin { get; set; }

    /// <summary>
    /// Minimum increment between valid price levels
    /// </summary>
    public string tick_size { get; set; }

    /// <summary>
    /// Status of asset. Possible values: <code>online</code>, <code>cancel_only</code>, <code>post_only</code>, <code>limit_only</code>, <code>reduce_only</code>. 
    /// </summary>
    public string status { get; set; }

    /// <summary>
    /// Maximum long margin position size (in terms of base currency) 
    /// </summary>
    public int long_position_limit { get; set; }

    /// <summary>
    /// Maximum short margin position size (in terms of base currency) 
    /// </summary>
    public int short_position_limit { get; set; }

}

