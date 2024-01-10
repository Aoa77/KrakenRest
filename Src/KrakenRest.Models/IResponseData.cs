using System.Text.Json.Serialization;

namespace KrakenRest.Models;

public interface IResponseData
{
    [JsonIgnore]
    Type? RequestType { get; }
}