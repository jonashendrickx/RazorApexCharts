namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the name of a donut label
/// </summary>
public class DonutLabelName
{
    /// <summary>
    /// Color of the name in the donut's label
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font family of the name in donut's label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size of the name in donut's label
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
    public bool Show { get; set; } = true;

    /// <summary>
    /// A custom formatter function to apply on the name text in dataLabel
    /// </summary>
    public string Formatter { get; set; }
}