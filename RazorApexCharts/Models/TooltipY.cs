namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to the Y-axis value of a tooltip
/// </summary>
/// <remarks>
/// In a multiple series, the tooltip.y property can accept array to target formatters of different series scales.
/// </remarks>
public class TooltipY
{
    /// <inheritdoc cref="TooltipYTitle" />
    public TooltipYTitle Title { get; set; }

    /// <summary>
    /// To format the Y-axis values of tooltip, you can define a custom formatter function. By default, these values will be formatted according yaxis.labels.formatter function which will be overrided by this function if you define it.
    /// 
    /// <code>
    /// tooltip: {
    ///     y: {
    ///         formatter: function(value, { series, seriesIndex, dataPointIndex, w }) {
    ///             return value
    ///         }
    ///     }
    /// }
    /// </code>
    /// </summary>
    public string Formatter { get; set; }
}