using System.Collections.Concurrent;
using System.Net.Http;
using System.Text.Json;
using Serilog;

namespace Bai_05.Services;

public class TyGiaKetQua
{
    public decimal TyGia { get; set; }
    public string Nguon { get; set; } = "";
    public string Host { get; set; } = "";
}

public class TyGiaService
{
    private static readonly HttpClient _httpClient = new();
    private static readonly ConcurrentDictionary<string, (decimal Rate, DateTime Expire, string Host)> _cache = new();

    private readonly ExchangeRateOptions _options;

    public TyGiaService(ExchangeRateOptions? options = null)
    {
        _options = options ?? AppConfig.GetExchangeRateOptions();
        _httpClient.Timeout = TimeSpan.FromSeconds(_options.TimeoutSeconds > 0 ? _options.TimeoutSeconds : 10);
    }

    public async Task<TyGiaKetQua?> LayTyGiaAsync(string ngoaiTe)
    {
        if (string.IsNullOrWhiteSpace(ngoaiTe))
            return null;

        string code = ngoaiTe.Trim().ToLowerInvariant();
        if (code == "vnd")
        {
            return new TyGiaKetQua { TyGia = 1m, Nguon = "local", Host = "local" };
        }

        if (_cache.TryGetValue(code, out var cached) && cached.Expire > DateTime.UtcNow)
        {
            Log.Information("Dùng cache tỷ giá {Code}, hết hạn {Expire}", code, cached.Expire);
            return new TyGiaKetQua
            {
                TyGia = cached.Rate,
                Nguon = "cache",
                Host = cached.Host
            };
        }

        string primaryUrl = BuildUrl(_options.PrimaryUrl, code);
        Log.Information("Đang gọi API tỷ giá chính: {Url}", primaryUrl);

        try
        {
            var rate = await FetchRateAsync(primaryUrl, code);
            if (rate.HasValue)
            {
                Cache(code, rate.Value, "cdn.jsdelivr.net");
                return new TyGiaKetQua
                {
                    TyGia = rate.Value,
                    Nguon = "primary",
                    Host = "cdn.jsdelivr.net"
                };
            }
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "API tỷ giá chính thất bại: {Reason}", ex.Message);
        }

        string fallbackUrl = BuildUrl(_options.FallbackUrl, code);
        Log.Information("Đang gọi API tỷ giá dự phòng: {Url}", fallbackUrl);

        try
        {
            var rate = await FetchRateAsync(fallbackUrl, code);
            if (rate.HasValue)
            {
                Cache(code, rate.Value, "latest.currency-api.pages.dev");
                return new TyGiaKetQua
                {
                    TyGia = rate.Value,
                    Nguon = "fallback",
                    Host = "latest.currency-api.pages.dev"
                };
            }
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "API tỷ giá dự phòng thất bại: {Reason}", ex.Message);
        }

        return null;
    }

    private void Cache(string code, decimal rate, string host)
    {
        int minutes = _options.CacheMinutes > 0 ? _options.CacheMinutes : 10;
        _cache[code] = (rate, DateTime.UtcNow.AddMinutes(minutes), host);
    }

    private static string BuildUrl(string template, string code)
        => template.Replace("{code}", code, StringComparison.OrdinalIgnoreCase);

    private static async Task<decimal?> FetchRateAsync(string url, string code)
    {
        using var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string json = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);
        if (!doc.RootElement.TryGetProperty(code, out var currencyObj))
            return null;

        if (!currencyObj.TryGetProperty("vnd", out var vndEl))
            return null;

        return vndEl.GetDecimal();
    }
}
