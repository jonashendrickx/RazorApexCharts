namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.BoxPlot"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/boxplot-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/boxplot">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/boxplot">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsBoxPlot
{
    /// <inheritdoc cref="BloxPlotColors" />
    public BloxPlotColors Colors { get; set; }
}