namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.RadialBar"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/radialbar-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/radialbar-gauge">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/radialbar">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsRadialBar
{
    /// <inheritdoc cref="RadialBarDataLabels" />
    public RadialBarDataLabels DataLabels { get; set; }

    /// <summary>
    /// Angle to which the radialBars should end. The sum of the startAngle and endAngle should not exceed 360.
    /// </summary>
    public double? EndAngle { get; set; }

    /// <inheritdoc cref="Models.Hollow" />
    public Hollow Hollow { get; set; }

    /// <summary>
    /// Whether to make the first value of series innermost or outermost
    /// </summary>
    public bool? InverseOrder { get; set; }

    /// <summary>
    /// Sets the left offset for radialBars
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for radialBars
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Angle from which the radialBars should start
    /// </summary>
    public double? StartAngle { get; set; }

    /// <inheritdoc cref="Models.Track" />
    public Track Track { get; set; }
}