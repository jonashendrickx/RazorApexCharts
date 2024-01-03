namespace RazorApexCharts.Models;

#pragma warning disable CS1591
/// <summary>
/// A list of shading options to apply to various data point states
/// </summary>

public enum StatesFilterType
{
    [JsonPropertyName("none")]
    None,
    
    [JsonPropertyName("lighten")]
    Lighten,
    
    [JsonPropertyName("darken")]
    Darken
}