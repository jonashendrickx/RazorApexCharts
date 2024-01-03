namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the rings in the polar area chart
/// </summary>
public class PolarAreaRings
{
    /// <summary>
    /// The line/border color of the rings of the chart.
    /// </summary>
    public string StrokeColor { get; set; }

    /// <summary>
    /// Border width of the rings of polarArea chart.
    /// </summary>
    public double? StrokeWidth { get; set; }
}