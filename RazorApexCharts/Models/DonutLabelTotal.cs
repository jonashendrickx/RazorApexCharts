namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the total label for a donut slice
/// </summary>
public class DonutLabelTotal
{
    /// <summary>
    /// Color of the total label
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font family of the total label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size of the total label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font-weight of the total label in dataLabel
    /// </summary>
    public object FontWeight { get; set; }

    /// <summary>
    /// Label for "total". Defaults to "Total"
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Show the total of all the series in the inner area of radialBar
    /// </summary>
    public bool Show { get; set; } = true;

    /// <summary>
    /// Always show the total label and do not remove it even when user clicks/hovers over the slices.
    /// </summary>
    public bool? ShowAlways { get; set; }

    /// <summary>
    /// A custom formatter function to apply on the total value. It accepts one parameter w which contains the chart's config and global objects. Defaults to a total of all series percentage divided by the length of series.
    /// </summary>
    public string Formatter { get; set; }
}