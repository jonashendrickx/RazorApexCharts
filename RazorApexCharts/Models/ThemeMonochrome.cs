namespace RazorApexCharts.Models;

/// <summary>
/// Single color is used as a base and shades are generated from that color.
/// </summary>
public class ThemeMonochrome
{
    /// <summary>
    /// A hex color which will be used as the base color for generating shades
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Whether to enable monochrome theme option.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// What should be the intensity while generating shades. Accepts from 0 to 1
    /// </summary>
    public double? ShadeIntensity { get; set; }

    /// <summary>
    /// The type of shade to apply
    /// </summary>
    public Mode? ShadeTo { get; set; }
}