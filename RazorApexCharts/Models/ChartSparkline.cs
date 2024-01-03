namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to use when creating sparklines for the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/chart/sparkline">JavaScript Reference</see>
/// </remarks>
public class ChartSparkline
{
    /// <summary>
    /// Sparkline hides all the elements of the charts other than the primary paths. Helps to visualize data in small areas. <see href="https://apexcharts.com/javascript-chart-demos/sparklines/basic">Example</see>
    /// </summary>
    public bool Enabled { get; set; } = true;
}