namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Bubble"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/bubble-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/bubble">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsBubble
{
    /// <summary>
    /// zScaling controls whether to draw the bubbles of different size (based on z value) or to draw same size bubbles (helpful in case your data-set contains values that extends to extreme ends)
    /// </summary>
    public bool? ZScaling { get; set; }

    /// <summary>
    /// Maximum radius size of a bubble. If a bubble value is too large to cover the chart, this size will be used.
    /// </summary>
    public double? MaxBubbleRadius { get; set; }

    /// <summary>
    /// Minimum radius size of a bubble. If a bubble value is too small to be displayed, this size will be used.
    /// </summary>
    public double? MinBubbleRadius { get; set; }
}