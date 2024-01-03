namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling to apply to the axis title
/// </summary>
public class AxisTitleStyle
{
    /// <summary>
    /// Fore color of the axis title
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// A custom CSS Class to give to the axis title
    /// </summary>
    public string CssClass { get; set; }

    /// <summary>
    /// Font family for the axis title
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size for the axis title
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font-weight for the axis title
    /// </summary>
    public object FontWeight { get; set; }
}