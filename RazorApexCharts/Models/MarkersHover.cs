namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling properties for when a marker is hovered
/// </summary>
public class MarkersHover
{
    /// <summary>
    /// Fixed size of the marker when it is active
    /// </summary>
    public double? Size { get; set; }

    /// <summary>
    /// Unlike the fixed size, this option takes the original markers.size and increases/decreases the value based on it. So, if markers.size: 6, markers.hover.sizeOffset: 3 will make the marker's size 9 when hovered.
    /// </summary>
    public double? SizeOffset { get; set; }
}