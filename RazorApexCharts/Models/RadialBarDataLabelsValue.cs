namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the value for each section of the radial bar chart
/// </summary>
public class RadialBarDataLabelsValue
{
    /// <summary>
    /// Color of the value label in dataLabel
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font family of the value label in dataLabel
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size of the value label in dataLabel
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font weight of the value label in dataLabel
    /// </summary>
    public object FontWeight { get; set; }

    /// <summary>
    /// Sets the top offset for value label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// A custom formatter function to apply on the value label in dataLabel
    /// </summary>
    public string Formatter { get; set; }

    /// <summary>
    /// Show the value label associated with the name label
    /// </summary>
    public bool? Show { get; set; }
}