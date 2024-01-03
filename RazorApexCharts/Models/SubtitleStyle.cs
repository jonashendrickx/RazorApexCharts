namespace RazorApexCharts.Models;

/// <summary>
/// Defines the style options to apply to the subtitle
/// </summary>
public class SubtitleStyle
{
    /// <summary>
    /// Fore color of the subtitle text
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Font Family of the subtitle text
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font Size of the subtitle text
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font Weight of the subtitle text
    /// </summary>
    public object FontWeight { get; set; }
}