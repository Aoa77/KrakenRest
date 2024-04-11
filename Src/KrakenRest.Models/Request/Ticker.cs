namespace KrakenRest.Models.Request;

public sealed class Ticker : RequestQuery
{
    public Ticker()
    {
        Optional = new[] { "pair" };
    }
}
