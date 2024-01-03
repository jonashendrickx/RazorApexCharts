namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the bar chart total labels
/// </summary>
public class BarDataLabelsStyle
{
    /// <summary>
    /// Color of the total label
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font size of the total label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font family of the total label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font-weight of the total label
    /// </summary>
    public object FontWeight { get; set; }
}