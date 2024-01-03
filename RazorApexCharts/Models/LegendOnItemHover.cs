namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to execute for when a legend item is hovered
/// </summary>
public class LegendOnItemHover
{
    /// <summary>
    /// When hovered on legend item, it will highlight the paths of the hovered series in chart.
    /// </summary>
    public bool? HighlightDataSeries { get; set; }
}