namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to use for generating a brush chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/chart/brush">JavaScript Reference</see>
/// </remarks>
public class Brush
{
    /// <summary>
    /// If set to true, the Y-axis will automatically scale based on the visible min/max range.
    /// </summary>
    /// <remarks>
    /// Note: One important configuration to set in a brush chart is the <see href="https://apexcharts.com/docs/options/chart/selection">chart.selection</see> option. The range which you set in <see cref="Chart.Selection"/> will act as brush in the brush chart
    /// </remarks>
    public bool? AutoScaleYaxis { get; set; }

    /// <summary>
    /// Turn on this option to enable brush chart options. After you enable brush, you need to set target chart ID to allow the brush chart to capture events on the target chart.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Chart ID of the target chart to sync the brush chart and the target chart. If you have an array of multiple chart IDs, use <see cref="Targets"/> property instead.
    /// </summary>
    public string Target { get; set; }

    /// <summary>
    /// Chart IDs of the target charts to sync the brush chart and the target charts. If you have a single chart ID, use <see cref="Target"/> property instead.
    /// </summary>
    public List<string> Targets { get; set; }
}