namespace RazorApexCharts.Models;

/// <summary>
/// Defines parameters for selections on the X-axis
/// </summary>
public class SelectionXaxis
{
    /// <summary>
    /// End value of x-axis. For a time-series chart, a timestamp should be provided.
    /// </summary>
    public double? Max { get; set; }

    /// <summary>
    /// Start value of x-axis. For a time-series chart, a timestamp should be provided
    /// </summary>
    public double? Min { get; set; }
}