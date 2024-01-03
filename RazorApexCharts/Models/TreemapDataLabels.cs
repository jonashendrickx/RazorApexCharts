namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style data labels within a treemap chart.
/// </summary>
public class TreemapDataLabels
{
    /// <summary>
    /// You can either set the labels to scale based on the box size, or you can keep the same font-size and let the labels truncate if they exceed the area.
    /// </summary>
    public Format Format { get; set; }
}