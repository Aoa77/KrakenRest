namespace KrakenRest.Models.Response;

public sealed class AssetPairs : Dictionary<string, AssetPair>, IResponseData
{
    public Type? RequestType { get; }
}


public class AssetPair
{
    public string altname { get; set; }
    public string wsname { get; set; }
    public string aclass_base { get; set; }
    public string _base { get; set; }
    public string aclass_quote { get; set; }
    public string quote { get; set; }
    public string lot { get; set; }
    public int cost_decimals { get; set; }
    public int pair_decimals { get; set; }
    public int lot_decimals { get; set; }
    public int lot_multiplier { get; set; }
    public object[] leverage_buy { get; set; }
    public object[] leverage_sell { get; set; }
    public float[][] fees { get; set; }
    public float[][] fees_maker { get; set; }
    public string fee_volume_currency { get; set; }
    public int margin_call { get; set; }
    public int margin_stop { get; set; }
    public string ordermin { get; set; }
    public string costmin { get; set; }
    public string tick_size { get; set; }
    public string status { get; set; }
}