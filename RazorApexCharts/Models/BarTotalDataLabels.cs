namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to display total values for the bars in the bar chart
/// </summary>
public class BarTotalDataLabels
{
    /// <summary>
    /// Enable total data-label in stacked bar charts which adds all the values of the category for those stacked data-sets
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Applies a custom function for the total value. The function accepts 2 params where the 1st one is the value while the 2nd one is the config object.
    /// </summary>
    public string Formatter { get; set; }

    /// <summary>
    /// Sets the left offset of the total label
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the total label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="BarDataLabelsStyle" />
    public BarDataLabelsStyle Style { get; set; }
}