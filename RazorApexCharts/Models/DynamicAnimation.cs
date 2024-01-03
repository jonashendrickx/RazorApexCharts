namespace RazorApexCharts.Models;

/// <summary>
/// Defines options for animations that run as the chart data changes
/// </summary>
public class DynamicAnimation
{
    /// <summary>
    /// Animate the chart when data is changed and chart is re-rendered.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Speed at which dynamic animation runs whenever data changes.
    /// </summary>
    public double? Speed { get; set; }
}