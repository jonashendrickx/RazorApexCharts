namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Radar"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/radar-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/radar">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/radar">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsRadar
{
    /// <summary>
    /// Sets the left offset of the radar
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the radar
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="RadarPolygons" />
    public RadarPolygons Polygons { get; set; }

    /// <summary>
    /// A custom size for the inner radar. The default size calculation will be overrided with this
    /// </summary>
    public double? Size { get; set; }
}