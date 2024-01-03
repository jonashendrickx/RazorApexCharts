using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to customize the display of the X-axis on the generated chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/axis">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/options/xaxis">JavaScript Reference</see>
/// </remarks>
public class XAxis
{
    /// <inheritdoc cref="RazorApexCharts.Models.AxisBorder" />
    [JsonPropertyName("axisBorder")]
    public AxisBorder AxisBorder { get; set; }

    /// <inheritdoc cref="RazorApexCharts.Models.AxisTicks" />
    [JsonPropertyName("axisTicks")]
    public AxisTicks AxisTicks { get; set; }

    /// <summary>
    /// Categories are labels which are displayed on the x-axis.
    /// </summary>
    [JsonPropertyName("categories")]
    public IEnumerable<object> Categories { get; set; }

    /// <summary>
    /// Allows you to overwrite all the labels of the x-axis with these labels. Accepts an array of string values.
    /// </summary>
    public List<string> OverwriteCategories { get; set; }

    /// <inheritdoc cref="AxisCrosshairs" />
    public AxisCrosshairs Crosshairs { get; set; }

    /// <summary>
    /// Setting this options takes the y-axis out of the plotting area. Much behaves like position: absolute property of CSS
    /// </summary>
    public bool? Floating { get; set; }

    /// <summary>
    /// The number of fractions to display when there are floating values on the x-axis numbers. Note: Works only in numeric type.
    /// </summary>
    public int? DecimalsInFloat { get; set; }

    /// <inheritdoc cref="XAxisLabels" />
    public XAxisLabels Labels { get; set; }

    /// <summary>
    /// The highest number to be set for the x-axis. The graph drawing beyond this number will be clipped off
    /// </summary>
    public object Max { get; set; }

    /// <summary>
    /// The lowest number to be set for the x-axis. The graph drawing beyond this number will be clipped off
    /// </summary>
    public object Min { get; set; }

    /// <summary>
    /// Sets the left offset for label
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Setting this option allows you to change the x-axis position
    /// </summary>
    public XAxisPosition Position { get; set; }

    /// <summary>
    /// Range takes the max value of x-axis, subtracts the provided range value and gets the min value based on that. So, technically it helps to keep the same range when min and max values gets updated dynamically
    /// </summary>
    public double? Range { get; set; }
    
    /// <summary>
    /// Number of Tick Intervals to show. Note: tickAmount doesn't have any effect when <see cref="Type"/> = <see cref="XAxisType.Datetime"/>
    /// </summary>
    /// <remarks>
    /// If you have a numeric xaxis <see cref="Type"/> = <see cref="XAxisType.Numeric"/>, you can specify tickAmount: 'dataPoints' which would make the number of ticks equal to the number of dataPoints in the chart.
    /// </remarks>
    [JsonPropertyName("tickAmount")]
    public object TickAmount { get; set; }

    /// <summary>
    /// Whether to draw the ticks in between the data-points or on the data-points.
    /// </summary>
    /// <remarks>
    /// Note: tickPlacement only works for <see cref="Type"/>: <see cref="XAxisType.Category"/> charts and not for <see cref="XAxisType.Datetime"/> charts.
    /// </remarks>
    public TickPlacement? TickPlacement { get; set; }

    /// <inheritdoc cref="AxisTitle" />
    public AxisTitle Title { get; set; }

    /// <inheritdoc cref="AxisTooltip" />
    public AxisTooltip Tooltip { get; set; }

    /// <summary>
    /// Specifies the data type to use for the x-axis
    /// </summary>
    [JsonPropertyName("type")]
    public XAxisTypes? Type { get; set; }

    /// <inheritdoc cref="XAxisGroups" />
    public XAxisGroups Group { get; set; }
}