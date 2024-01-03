using System.Text.Json;

namespace RazorApexCharts.Serialization;

public static class ApexJsonSerializerOptions
{
    public static readonly JsonSerializerOptions Value = new()
    {
        Converters =
        {
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
        },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
}