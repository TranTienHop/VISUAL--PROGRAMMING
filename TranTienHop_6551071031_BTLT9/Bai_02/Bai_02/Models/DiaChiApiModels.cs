using System.Text.Json.Serialization;

namespace Bai_02.Models;

public class ProvinceDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("code")]
    public int Code { get; set; }
}

public class WardDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("code")]
    public int Code { get; set; }
}

public class ProvinceDetailDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("wards")]
    public List<WardDto> Wards { get; set; } = new();
}
