namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the fill for the zoomed area of the chart
/// </summary>
public class ZoomedAreaFill
{
    /// <summary>
    /// Background color of the selection zoomed area
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Sets the transparency level of the selection fill
    /// </summary>
    public double? Opacity { get; set; }
}