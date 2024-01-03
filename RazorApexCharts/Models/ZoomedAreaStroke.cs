namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the stroke for the zoomed area of the chart
/// </summary>
public class ZoomedAreaStroke
{
    /// <summary>
    /// Border color of the selection zoomed area
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Sets the transparency level of the selection border
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Sets the width selection border
    /// </summary>
    public double? Width { get; set; }
}