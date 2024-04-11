namespace KrakenRest.Models.Response;

public sealed class Time : IResponseData
{
    public int unixtime { get; set; }
    public string rfc1123 { get; set; }
    public Type? RequestType => null;
}
