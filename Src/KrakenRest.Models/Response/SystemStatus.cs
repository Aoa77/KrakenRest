namespace KrakenRest.Models.Response;

public sealed class SystemStatus : IResponseData
{
    public string status { get; set; }
    public DateTime timestamp { get; set; }
    public Type? RequestType { get; }
}
