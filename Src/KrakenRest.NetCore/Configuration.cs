using System.Runtime.CompilerServices;

namespace KrakenRest.NetCore;

public sealed class Configuration
{
    public const string AppSettingsJson = "appsettings.json";
    private readonly IConfiguration _configuration;

    public bool Debug => GetValue<bool>();
    public bool StrongModels => GetValue<bool>();
    public string MarketApiUrl => GetValue<string>()!;

    public Configuration(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private T? GetValue<T>([CallerMemberName] string key = null!)
    {
        return _configuration.GetValue<T>($@"{nameof(Configuration)}:{key}")
            ?? throw new InvalidOperationException(
                $"Configuration key {key} not found");
    }

}
