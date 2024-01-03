namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to display labels on the pie chart
/// </summary>
public class PieDataLabels
{
    /// <summary>
    /// Minimum angle to allow data-labels to show. If the slice angle is less than this number, the label would not show to prevent overlapping issues.
    /// </summary>
    public double? MinAngleToShowLabel { get; set; }

    /// <summary>
    /// Offset by which labels will move outside / inside of the donut area
    /// </summary>
    public double? Offset { get; set; }
}