using System.Net.Http;
using System.Text.Json;
using Bai_02.Models;
using Serilog;

namespace Bai_02.Services;

public class DiaChiService
{
    private static readonly HttpClient _httpClient = CreateClient();

    private static HttpClient CreateClient()
    {
        var client = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        return client;
    }

    public async Task<List<ProvinceDto>> LayDanhSachTinhAsync()
    {
        string url = "https://provinces.open-api.vn/api/v2/";
        using var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<ProvinceDto>>(json) ?? new List<ProvinceDto>();
    }

    public async Task<List<WardDto>> LayDanhSachPhuongXaAsync(int maTinh)
    {
        string url = $"https://provinces.open-api.vn/api/v2/p/{maTinh}?depth=2";
        using var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string json = await response.Content.ReadAsStringAsync();
        var detail = JsonSerializer.Deserialize<ProvinceDetailDto>(json);
        return detail?.Wards ?? new List<WardDto>();
    }

    public static void LogNetworkError(Exception ex)
    {
        Log.Warning(ex, "Không tải được danh sách địa chỉ từ API");
    }
}
