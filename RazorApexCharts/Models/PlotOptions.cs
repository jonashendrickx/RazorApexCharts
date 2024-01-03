namespace RazorApexCharts.Models;

/// <summary>
/// Container class to store options for each specific type of chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/plotoptions">JavaScript Reference</see>
/// </remarks>
public class PlotOptions
{
    /// <inheritdoc cref="PlotOptionsArea" />
    public PlotOptionsArea Area { get; set; }

    /// <inheritdoc cref="PlotOptionsBar" />
    public PlotOptionsBar Bar { get; set; }

    /// <inheritdoc cref="PlotOptionsBubble" />
    public PlotOptionsBubble Bubble { get; set; }

    /// <inheritdoc cref="PlotOptionsCandlestick" />
    public PlotOptionsCandlestick Candlestick { get; set; }

    /// <inheritdoc cref="PlotOptionsBoxPlot" />
    public PlotOptionsBoxPlot BoxPlot { get; set; }

    /// <inheritdoc cref="PlotOptionsHeatmap" />
    public PlotOptionsHeatmap Heatmap { get; set; }

    /// <inheritdoc cref="PlotOptionsPie" />
    public PlotOptionsPie Pie { get; set; }

    /// <inheritdoc cref="PlotOptionsPolarArea" />
    public PlotOptionsPolarArea PolarArea { get; set; }

    /// <inheritdoc cref="PlotOptionsRadar" />
    public PlotOptionsRadar Radar { get; set; }

    /// <inheritdoc cref="PlotOptionsRadialBar" />
    public PlotOptionsRadialBar RadialBar { get; set; }

    /// <inheritdoc cref="PlotOptionsTreemap" />
    public PlotOptionsTreemap Treemap { get; set; }
}