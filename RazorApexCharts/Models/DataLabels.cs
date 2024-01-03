namespace RazorApexCharts.Models;

/// <summary>
/// Data Labels are the actual values which are passed in the series. You can add formatters which will allow you to modify values before displaying.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/datalabels">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/datalabels">JavaScript Reference</see>
/// </remarks>
public class DataLabels
{
    /// <inheritdoc cref="DataLabelsBackground"/>
    public DataLabelsBackground Background { get; set; }

    /// <summary>
    /// Similar to plotOptions.bar.distributed, this option makes each data-label discrete. So, when you provide an array of colors in datalabels.style.colors, the index in the colors array correlates with individual data-label index of all series.
    /// </summary>
    public bool? Distributed { get; set; }

    /// <inheritdoc cref="Models.DropShadow"/>
    public DropShadow DropShadow { get; set; }

    /// <summary>
    /// To determine whether to show dataLabels or not
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Allows showing series only on specific series in a multi-series chart. For eg., if you have a line and a column chart, you can show dataLabels only on the line chart by specifying it's index in this array property.
    /// </summary>
    public List<double> EnabledOnSeries { get; set; }

    /// <summary>
    /// Sets the left offset for dataLabels
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for dataLabels
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="DataLabelsStyle"/>
    public DataLabelsStyle Style { get; set; }

    /// <summary>
    /// The alignment of text relative to dataLabel's drawing position
    /// </summary>
    public TextAnchor? TextAnchor { get; set; }

    /// <summary>
    /// The formatter function allows you to modify the value before displaying. Example:
    /// 
    /// <code>
    /// formatter: function(value, { seriesIndex, dataPointIndex, w }) {
    ///     return w.config.series[seriesIndex].name + ":  " + value
    /// }
    /// </code>
    /// 
    /// In the code above, seriesIndex is useful in multi-series chart, while dataPointIndex is the index of data-point in that series. w is an object consisting all globals and configuration which can be utilized the way mentioned in the above code.
    /// </summary>
    public string Formatter { get; set; }
}