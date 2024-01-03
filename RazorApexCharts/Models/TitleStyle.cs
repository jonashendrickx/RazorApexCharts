namespace RazorApexCharts.Models;

/// <summary>
/// Defines the style options to apply to the title
/// </summary>
public class TitleStyle
{
    /// <summary>
    /// Fore color of the title text
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font Family of the title text
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font Size of the title text
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font Weight of the title text
    /// </summary>
    public object FontWeight { get; set; }
}