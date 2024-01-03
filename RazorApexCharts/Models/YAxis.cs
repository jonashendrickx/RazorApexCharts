namespace RazorApexCharts.Models;

/// <summary>
/// Class to customize the display of the Y-axis on the generated chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/axis">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/options/yaxis">JavaScript Reference</see>
/// </remarks>
public class YAxis
{
    /// <inheritdoc cref="Models.AxisBorder" />
    public AxisBorder AxisBorder { get; set; }

    /// <inheritdoc cref="Models.AxisTicks" />
    public AxisTicks AxisTicks { get; set; }

    /// <inheritdoc cref="AxisCrosshairs" />
    public AxisCrosshairs Crosshairs { get; set; }

    /// <summary>
    /// The number of fractions to display when there are floating values in y-axis. Note: If you have defined a custom formatter function in yaxis.labels.formatter, this won't have any effect.
    /// </summary>
    public int? DecimalsInFloat { get; set; }

    /// <summary>
    /// etting this options takes the y-axis out of the plotting area. Much behaves like position: absolute property of CSS
    /// </summary>
    public bool? Floating { get; set; }

    /// <summary>
    /// If set to true, the y-axis scales are forced to generate nice looking rounded numbers even when min/max are provided. Turn this off if you manually set min/max and want it to be unchanged.
    /// </summary>
    public bool? ForceNiceScale { get; set; }

    /// <inheritdoc cref="YAxisLabels" />
    public YAxisLabels Labels { get; set; }

    /// <summary>
    /// A non-linear scale when there is a large range of values.
    /// </summary>
    public bool? Logarithmic { get; set; }

    /// <summary>
    /// Controls the logarithmic base. Default is 10
    /// </summary>
    public decimal? LogBase { get; set; }

    /// <summary>
    /// The highest number to be set for the y-axis. The graph drawing beyond this number will be clipped off.
    /// </summary>
    /// <remarks>
    /// You can also pass a function here which should return a number.The function accepts an argument which by default is the biggest value in the y-axis.function(max) { return max }
    /// </remarks>
    public object Max { get; set; }

    /// <summary>
    /// The lowest number to be set for the y-axis. The graph drawing beyond this number will be clipped off.
    /// </summary>
    /// <remarks>
    /// You can also pass a function here which should return a number.The function accepts an argument which by default is the smallest value in the y-axis.function(min) { return min }
    /// </remarks>
    public object Min { get; set; }

    /// <summary>
    /// When enabled, will draw the yaxis on the right side of the chart
    /// </summary>
    public bool? Opposite { get; set; }

    /// <summary>
    /// Flip the chart upside down making it inversed and draw the y-axis from bigger to smaller numbers.
    /// </summary>
    public bool? Reversed { get; set; }

    /// <summary>
    /// In a multiple y-axis chart, you can target the scale of a y-axis to a particular series by referencing through the seriesName. The series item which have the same name property will be used to calculate the scale of the y-axis.
    /// </summary>
    public string SeriesName { get; set; }

    /// <summary>
    /// Whether to display the y-axis or not.
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// Whether to hide y-axis when user toggles series through legend.
    /// </summary>
    public bool? ShowAlways { get; set; }

    /// <summary>
    /// When turned off, it will hide the y-axis completely for a series which has no data or a series with all null values.
    /// </summary>
    public bool? ShowForNullSeries { get; set; }

    /// <summary>
    /// Number of Tick Intervals to show
    /// </summary>
    public double? TickAmount { get; set; }

    /// <inheritdoc cref="AxisTitle" />
    public AxisTitle Title { get; set; }

    /// <inheritdoc cref="YAxisTooltip" />
    public YAxisTooltip Tooltip { get; set; }
}