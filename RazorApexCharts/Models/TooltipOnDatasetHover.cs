namespace RazorApexCharts.Models;

/// <summary>
/// Defines options for hovering over the data set of the chart
/// </summary>
public class TooltipOnDatasetHover
{
    /// <summary>
    /// When user hovers over a datapoint of a particular series, other series will be grayed out making the current series highlight.
    /// </summary>
    public bool? HighlightDataSeries { get; set; }
}