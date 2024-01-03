namespace RazorApexCharts.Models;

/// <summary>
/// Defines parameters for the selections on the Y-axis
/// </summary>
public class SelectionYaxis
{
    /// <summary>
    /// End value of y-axis (if used in a multiple y-axes chart, this considers the 1st y-axis).
    /// </summary>
    public double? Max { get; set; }

    /// <summary>
    /// Start value of y-axis. (if used in a multiple y-axes chart, this considers the 1st y-axis).
    /// </summary>
    public double? Min { get; set; }
}