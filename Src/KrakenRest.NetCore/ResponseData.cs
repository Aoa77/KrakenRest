namespace KrakenRest.NetCore;

public sealed class ResponseData<T>
{
    public IEnumerable<string>? error { get; set; }
    public T? result { get; set; }
}
