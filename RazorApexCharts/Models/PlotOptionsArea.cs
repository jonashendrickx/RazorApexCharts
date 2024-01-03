using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Area"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/area-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/area-chart">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/area">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsArea
{
    /// <summary>
    /// When negative values are present in the area chart, this option fill the area either from 0 (origin) or from the end of the chart as illustrated below.
    /// </summary>
    public AreaFillTo? FillTo { get; set; }
}