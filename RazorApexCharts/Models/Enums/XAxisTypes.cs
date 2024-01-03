namespace RazorApexCharts.Models.Enums;


public enum XAxisTypes
{
    [JsonPropertyName("category")]
    Category,
    
    [JsonPropertyName("datetime")]
    Datetime,
    
    [JsonPropertyName("numeric")]
    Numeric
}