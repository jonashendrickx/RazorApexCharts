namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to X-axis tooltips
/// </summary>
public class AxisTooltip
{
    /// <summary>
    /// Show tooltip on axis or not
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Sets the top offset for axis tooltip
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// A custom formatter function for the x-axis tooltip label. If undefined, the xaxis tooltip uses the default "X" value used in general tooltip. Example:
    /// 
    /// <code>
    /// xaxis: {
    ///     tooltip: {
    ///         formatter: function(val, opts) {
    ///             return val + "..."
    ///         }
    ///     }
    /// }
    /// </code>
    /// </summary>
    public string Formatter { get; set; }

    /// <inheritdoc cref="AxisTooltipStyle" />
    public AxisTooltipStyle Style { get; set; }
}