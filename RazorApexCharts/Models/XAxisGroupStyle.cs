namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling to apply to X-axis groups
/// </summary>
public class XAxisGroupStyle
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Fore color for the x-axis groups label.
    /// </summary>
    public Color Colors { get; set; }

    /// <summary>
    /// Font size for the x-axis group label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font family for the x-axis group label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font-weight for the x-axis group label
    /// </summary>
    public string FontWeight { get; set; }

    /// <summary>
    /// A custom Css Class to give to the label elements
    /// </summary>
    public string CssClass { get; set; }
}