namespace RazorApexCharts.Models.Enums;


public enum ChartTypes
{
    [JsonPropertyName("line")]
    Line,

    [JsonPropertyName("area")]
    Area,

    [JsonPropertyName("bar")]
    Bar,

    [JsonPropertyName("pie")]
    Pie,

    [JsonPropertyName("donut")]
    Donut,

    [JsonPropertyName("radial_bar")]
    RadialBar,

    [JsonPropertyName("scatter")]
    Scatter,

    [JsonPropertyName("bubble")]
    Bubble,

    [JsonPropertyName("heatmap")]
    Heatmap,

    [JsonPropertyName("candlestick")]
    Candlestick,

    [JsonPropertyName("box_plot")]
    BoxPlot,

    [JsonPropertyName("radar")]
    Radar,

    [JsonPropertyName("polar_area")]
    PolarArea,

    [JsonPropertyName("range_bar")]
    RangeBar,

    [JsonPropertyName("range_area")]
    RangeArea,

    [JsonPropertyName("treemap")]
    Treemap
}