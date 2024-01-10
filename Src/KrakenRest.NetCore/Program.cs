using RestSharp;
namespace KrakenRest.NetCore;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // add config
        builder.Configuration.AddJsonFile(
            Configuration.AppSettingsJson,
            optional: false,
            reloadOnChange: true);

        // build the app
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();
        app.UseAuthorization();

        // run
        var config = new Configuration(app.Configuration);
        var client = CreateRestClient(config.MarketApiUrl);
        app.MapRest(client, config);
        app.Run();
    }

    private static RestClient CreateRestClient(string? url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentNullException(nameof(url));
        }
        return new RestClient(url);
    }
}
