using System.Drawing;

namespace RazorApexCharts.Models;

/// <summary>
/// The style options to apply to the radar chart
/// </summary>
public class RadarPolygons
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// The line color of the connector lines of the polygons.
    /// </summary>
    public Color ConnectorColors { get; set; }

    /// <inheritdoc cref="RadarPolygonsFill" />
    public RadarPolygonsFill Fill { get; set; }

    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// The line/border color of the spokes of the chart excluding the connector lines.
    /// </summary>
    public Color StrokeColors { get; set; }

    /// <inheritdoc cref="Size"/>
    /// <summary>
    /// Border width of the spokes of radar chart.
    /// </summary>
    public Size StrokeWidth { get; set; }
}