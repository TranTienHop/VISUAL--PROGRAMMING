using Microsoft.Extensions.Configuration;

namespace Bai_05;

public static class AppConfig
{
    private static IConfigurationRoot? _configuration;

    public static IConfigurationRoot Configuration
    {
        get
        {
            if (_configuration == null)
            {
                _configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
            }
            return _configuration;
        }
    }

    public static string? GetConnectionString()
        => Configuration.GetConnectionString("QL_DatTour");

    public static ExchangeRateOptions GetExchangeRateOptions()
    {
        var options = new ExchangeRateOptions();
        Configuration.GetSection("ExchangeRate").Bind(options);
        return options;
    }
}

public class ExchangeRateOptions
{
    public string PrimaryUrl { get; set; } =
        "https://cdn.jsdelivr.net/npm/@fawazahmed0/currency-api@latest/v1/currencies/{code}.json";

    public string FallbackUrl { get; set; } =
        "https://latest.currency-api.pages.dev/v1/currencies/{code}.json";

    public int TimeoutSeconds { get; set; } = 10;

    public int CacheMinutes { get; set; } = 10;
}
