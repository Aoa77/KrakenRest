namespace KrakenRest.Models;

public interface IRequestQuery
{
    IEnumerable<string> Required { get; }
    IEnumerable<string> Optional { get; }
}

public abstract class RequestQuery : IRequestQuery
{
    public IEnumerable<string> Required { get; protected set; }
    public IEnumerable<string> Optional { get; protected set; }

    protected RequestQuery()
    {
        Required = Enumerable.Empty<string>();
        Optional = Enumerable.Empty<string>();
    }
}