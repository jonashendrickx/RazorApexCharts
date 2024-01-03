namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the border of the crosshairs
/// </summary>
public class CrosshairStroke
{
    /// <summary>
    /// Border Color of crosshairs
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Creates dashes in borders of crosshairs. A higher number creates more space between dashes in the border.
    /// </summary>
    public double? DashArray { get; set; }

    /// <summary>
    /// Border Width of crosshairs
    /// </summary>
    public double? Width { get; set; }
}