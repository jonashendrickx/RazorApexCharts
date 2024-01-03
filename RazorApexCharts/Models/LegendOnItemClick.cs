namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to execute for when a legend item is clicked
/// </summary>
public class LegendOnItemClick
{
    /// <summary>
    /// When clicked on legend item, it will toggle the visibility of the series in chart.
    /// </summary>
    public bool? ToggleDataSeries { get; set; }
}