namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the name for each section of the radial bar chart
/// </summary>
public class RadialBarDataLabelsName
{
    /// <summary>
    /// Color of the name in dataLabel
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font family of the name in dataLabel
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size of the name in dataLabel
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font-weight of the name in dataLabel
    /// </summary>
    public object FontWeight { get; set; }

    /// <summary>
    /// Sets the top offset for name
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Show the name of the respective bar associated with it's value
    /// </summary>
    public bool? Show { get; set; }
}