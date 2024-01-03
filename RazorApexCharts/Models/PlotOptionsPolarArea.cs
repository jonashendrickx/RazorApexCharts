namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.PolarArea"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/plotoptions/polararea">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsPolarArea
{
    /// <inheritdoc cref="PolarAreaRings" />
    public PolarAreaRings Rings { get; set; }

    /// <inheritdoc cref="PolarAreaSpokes" />
    public PolarAreaSpokes Spokes { get; set; }
}