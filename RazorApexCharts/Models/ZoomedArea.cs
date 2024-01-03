namespace RazorApexCharts.Models;

/// <summary>
/// Zoomed Area is the area which is drawn when a user drags the mouse from one point to another
/// </summary>
public class ZoomedArea
{
    /// <inheritdoc cref="ZoomedAreaFill" />
    public ZoomedAreaFill Fill { get; set; }

    /// <inheritdoc cref="ZoomedAreaStroke" />
    public ZoomedAreaStroke Stroke { get; set; }
}