namespace RazorApexCharts.Models;

/// <summary>
/// Override everything and define your own stops with unlimited color stops. <see href="https://codepen.io/apexcharts/pen/RvqdPb">Codepen Example</see>
/// </summary>
public class FillGradientStops
{
    /// <summary>
    /// The location within the chart to apply the gradient stop at
    /// </summary>
    public double? Offset { get; set; }

    /// <summary>
    /// The color to apply at the gradient stop
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// The opacity to apply at the gradient stop. Accepts values from 0 to 1
    /// </summary>
    public double? Opacity { get; set; }
}