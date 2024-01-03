using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines options and styling to apply to the chart when items are selected within it
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/chart/selection">JavaScript Reference</see>
/// </remarks>
public class Selection
{
    /// <summary>
    /// To allow selection in axis charts. Selection will not be enabled for category x-axis charts, but only for charts having numeric x-axis. For eg., timeline charts.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <inheritdoc cref="SelectionFill" />
    public SelectionFill Fill { get; set; }

    /// <inheritdoc cref="SelectionStroke" />
    public SelectionStroke Stroke { get; set; }

    /// <summary>
    /// Allow selection either on both x-axis, y-axis or on both axis.
    /// </summary>
    public AxisType Type { get; set; }

    /// <inheritdoc cref="SelectionXaxis" />
    public SelectionXaxis Xaxis { get; set; }

    /// <inheritdoc cref="SelectionYaxis" />
    public SelectionYaxis Yaxis { get; set; }
}