using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Bar"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/bar-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/bar-chart">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/bar">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsBar
{
    /// <summary>
    /// This option will turn a column chart into a horizontal bar chart.
    /// </summary>
    public bool? Horizontal { get; set; }

    /// <summary>
    /// Rounded corners around the bars/columns.
    /// </summary>
    public double? BorderRadius { get; set; }

    /// <summary>
    /// Whether to apply border-radius around both ends or only to single end
    /// </summary>
    public BorderRadiusApplication? BorderRadiusApplication { get; set; }

    /// <summary>
    /// Whether to apply border-radius to all bars or only to the data-set that is drawn last
    /// </summary>
    public BorderRadiusWhenStacked? BorderRadiusWhenStacked { get; set; }

    /// <summary>
    /// In column charts, columnWidth is the percentage of the available width in the grid-rect. Accepts '0%' to '100%'
    /// </summary>
    public string ColumnWidth { get; set; }

    /// <summary>
    /// In horizontal bar charts, barHeight is the percentage of the available height in the grid-rect. Accepts '0%' to '100%'
    /// </summary>
    public string BarHeight { get; set; }

    /// <summary>
    /// Turn this option to make the bars discrete. Each value indicates one bar per series.
    /// </summary>
    public bool? Distributed { get; set; }

    /// <summary>
    /// In a range-Bar / timeline chart, the bars should overlap over each other instead of stacking if this option is enabled.
    /// </summary>
    public bool? RangeBarOverlap { get; set; }

    /// <summary>
    /// In a multi-series range-Bar / timeline chart, group rows (horizontal bars) together instead of stacking up. Helpful when there are no overlapping rows but distinct values.
    /// </summary>
    public bool? RangeBarGroupRows { get; set; }

    /// <summary>
    /// In a non-stacked (grouped or clustered) bar chart, do not occupy space for those bars whose value is zero.
    /// </summary>
    public bool? HideZeroBarsWhenGrouped { get; set; }

    /// <summary>
    /// Is chart a dumbbell
    /// </summary>
    public bool? IsDumbbell { get; set; }

    /// <summary>
    /// When dumbbell chart is enabled, use this option to set custom colors for the dots at the starting and ending shape.
    /// </summary>
    public List<string> DumbbellColors { get; set; }

    /// <summary>
    /// Is chart funnel
    /// </summary>
    public bool? IsFunnel { get; set; }

    /// <summary>
    /// Chart is funnel 3D
    /// </summary>
    public bool? IsFunnel3d { get; set; }

    /// <inheritdoc cref="PlotOptionsBarColors" />
    public PlotOptionsBarColors Colors { get; set; }

    /// <inheritdoc cref="PlotOptionsBarDataLabels" />
    public PlotOptionsBarDataLabels DataLabels { get; set; }
}