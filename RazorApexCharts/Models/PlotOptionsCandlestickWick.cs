namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the wick portion of the candlestick chart
/// </summary>
public class PlotOptionsCandlestickWick
{
    /// <summary>
    /// Use the same fill color for the wick. If this is false, the color of the wick falls back to the stroke.
    /// </summary>
    public bool? UseFillColor { get; set; }
}