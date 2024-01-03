namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the spokes in the polar area chart
/// </summary>
public class PolarAreaSpokes
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// The line/border color of the spokes of polarArea chart.
    /// </summary>
    public Color ConnectorColors { get; set; }

    /// <summary>
    /// Border width of the spokes of polarArea chart.
    /// </summary>
    public double? StrokeWidth { get; set; }
}