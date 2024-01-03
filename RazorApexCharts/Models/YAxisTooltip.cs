namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to Y-axis tooltips
/// </summary>
public class YAxisTooltip
{
    /// <summary>
    /// Show tooltip on y-axis
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Sets the top offset for y-axis tooltip
    /// </summary>
    public double? OffsetX { get; set; }
}