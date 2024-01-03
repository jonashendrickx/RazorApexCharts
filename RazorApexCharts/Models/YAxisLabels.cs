using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style labels on the Y-axis
/// </summary>
public class YAxisLabels
{
    /// <inheritdoc cref="Models.DatetimeFormatter" />
    [Obsolete("Property has been removed", false)]
    public DatetimeFormatter DatetimeFormatter { get; set; }

    /// <summary>
    /// Applies a custom function for the yaxis value.
    /// 
    /// <code>
    /// yaxis: {
    ///     labels: {
    ///         formatter: function(val, index) {
    ///             return val.toFixed(2);
    ///         }
    ///     }
    /// }
    /// </code>
    /// </summary>
    /// <remarks>
    /// Note: In horizantal bar charts, the second parameters also contains additional data like dataPointIndex &amp; seriesIndex.
    /// </remarks>
    public string Formatter { get; set; }

    /// <summary>
    /// Maximum width for the y-axis labels
    /// </summary>
    public double? MaxWidth { get; set; }

    /// <summary>
    /// Minimum width for the y-axis labels
    /// </summary>
    public double? MinWidth { get; set; }

    /// <summary>
    /// Sets the left offset for label
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Rotate y-axis text label to a specific angle from it's center
    /// </summary>
    public double? Rotate { get; set; }

    /// <summary>
    /// Show labels on y-axis
    /// </summary>
    public bool? Show { get; set; }

    /// <inheritdoc cref="AxisLabelStyle" />
    public AxisLabelStyle Style { get; set; }

    /// <summary>
    /// Alignment of Y-axis label relative to chart area.
    /// </summary>
    public Align? Align { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public double? Padding { get; set; }
}