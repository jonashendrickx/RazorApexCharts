namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling to apply to the axis labels
/// </summary>
public class AxisLabelStyle
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Fore color for the axis label.
    /// </summary>
    public Color Colors { get; set; }

    /// <summary>
    /// A custom Css Class to give to the label elements
    /// </summary>
    public string CssClass { get; set; }

    /// <summary>
    /// Font family for the axis label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size for the axis label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font-weight for the axis label
    /// </summary>
    public object FontWeight { get; set; }
}