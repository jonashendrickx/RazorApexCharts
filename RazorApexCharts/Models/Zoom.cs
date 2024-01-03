using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to configure how zooming works on the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/chart/zoom">JavaScript Reference</see>
/// </remarks>
public class Zoom
{
    /// <summary>
    /// When this option is turned on, the chart's y-axis re-scales to a new low and high based on the visible area. Helpful in situations where the user zoomed in to a small area to get a better view.
    /// </summary>
    /// <remarks>
    /// Known Issue: This option doesn't work in a multi-axis chart (when you have more than 1 y-axis)
    /// </remarks>
    public bool? AutoScaleYaxis { get; set; }

    /// <summary>
    /// To allow zooming in axis charts.
    /// </summary>
    /// <remarks>
    /// Note: In a category x-axis chart, to enable zooming, you will also need to set <see cref="XAxis.TickPlacement"/>: '<see cref="TickPlacement.On"/>'. Read more on the <see href="https://apexcharts.com/docs/zooming-in-category-x-axis">Category Axis Zoom</see> tutorial.
    /// </remarks>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Allow zooming either on both x-axis, y-axis or on both axis.
    /// </summary>
    /// <remarks>
    /// Known Issue: In <see href="https://apexcharts.com/javascript-chart-demos/line-charts/syncing-charts">synchronized charts</see>, <see cref="AxisType.Xy"/> or <see cref="AxisType.Y"/> will not update charts in sync, while <see cref="AxisType.X"/> will work correctly.
    /// </remarks>
    public AxisType? Type { get; set; }

    /// <inheritdoc cref="Models.ZoomedArea" />
    public ZoomedArea ZoomedArea { get; set; }
}