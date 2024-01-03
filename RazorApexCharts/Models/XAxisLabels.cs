namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style labels on the X-axis
/// </summary>
public class XAxisLabels
{
    /// <inheritdoc cref="Models.DatetimeFormatter" />
    public DatetimeFormatter DatetimeFormatter { get; set; }

    /// <summary>
    /// When turned on, local DateTime is converted into UTC. Turn it off if you supply date with timezone info and want to preserve it.
    /// </summary>
    public bool? DatetimeUTC { get; set; }

    /// <summary>
    /// Formats the datetime value based on the format specifier.
    /// </summary>
    /// <remarks>
    /// See the list of available <see href="https://apexcharts.com/docs/datetime">format specifiers</see>
    /// </remarks>
    public string Format { get; set; }

    /// <summary>
    /// Overrides everything and applies a custom function for the xaxis value. The function accepts 3 arguments. The first one is the default formatted value and the second one as the raw timestamp which you can pass to any datetime handling function to suit your needs. The 3rd argument is present in date-time xaxis which includes a dateFormatter as described in the code below.
    /// 
    /// <code>
    /// xaxis: {
    ///     labels: {
    ///         formatter: function(value, timestamp, opts) {
    ///             return opts.dateFormatter(new Date(timestamp)).format("dd MMM")
    ///         }
    ///     }
    /// }
    /// </code>
    /// </summary>
    public string Formatter { get; set; }

    /// <summary>
    /// When labels are too close and start to overlap on one another, this option prevents overlapping of the labels.
    /// </summary>
    public bool? HideOverlappingLabels { get; set; }

    /// <summary>
    /// Maximum height for the labels when they are rotated.
    /// </summary>
    public double? MaxHeight { get; set; }

    /// <summary>
    /// Minimum height for the labels
    /// </summary>
    public double? MinHeight { get; set; }

    /// <summary>
    /// Sets the left offset for label
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Rotate angle for the x-axis labels
    /// </summary>
    public double? Rotate { get; set; }

    /// <summary>
    /// Whether to rotate the labels always or to rotate only when the texts don't fit the available width
    /// </summary>
    public bool? RotateAlways { get; set; }

    /// <summary>
    /// Show labels on x-axis
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// By default, duplicate labels are not printed to prevent congested values in a datetime series. If you intentionally want to display the same values in x-axis labels, turn on this option
    /// </summary>
    public bool? ShowDuplicates { get; set; }

    /// <inheritdoc cref="AxisLabelStyle" />
    public AxisLabelStyle Style { get; set; }

    /// <summary>
    /// Append ... to the text when it can't fit the available space and rotate is turned off
    /// </summary>
    public bool? Trim { get; set; }
}