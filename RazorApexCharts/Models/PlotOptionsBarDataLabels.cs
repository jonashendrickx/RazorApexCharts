using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines text to display with bars in the bar chart
/// </summary>
public class PlotOptionsBarDataLabels
{
    /// <summary>
    /// When there are values that are very close to one another, this property prevents it by hiding overlapping labels. Note: This affects only stacked charts
    /// </summary>
    public bool? HideOverflowingLabels { get; set; }

    /// <summary>
    /// Maximum limit of data-labels that can be displayed on a bar chart. If data-points exceed this number, data-labels won't be shown.
    /// </summary>
    public double? MaxItems { get; set; }

    /// <summary>
    /// How to display the text
    /// </summary>
    public Orientation? Orientation { get; set; }

    /// <summary>
    /// Where to display the text
    /// </summary>
    public BarDataLabelPosition Position { get; set; }

    /// <inheritdoc cref="BarTotalDataLabels" />
    public BarTotalDataLabels Total { get; set; }
}