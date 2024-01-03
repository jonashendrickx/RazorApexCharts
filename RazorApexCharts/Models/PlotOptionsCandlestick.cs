namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Candlestick"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/candlestick-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/candlestick">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/candlestick">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsCandlestick
{
    /// <inheritdoc cref="PlotOptionsCandlestickColors" />
    public PlotOptionsCandlestickColors Colors { get; set; }

    /// <inheritdoc cref="PlotOptionsCandlestickWick" />
    public PlotOptionsCandlestickWick Wick { get; set; }
}