namespace RazorApexCharts.Models;

/// <summary>
/// Styling options to apply when there is no data in the chart
/// </summary>
public class NoDataStyle
{
    /// <summary>
    /// Fore color of the text
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font family of the text
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size of the text
    /// </summary>
    public string FontSize { get; set; }
}