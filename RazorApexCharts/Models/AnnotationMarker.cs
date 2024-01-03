namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the marker for a data annotation point
/// </summary>
public class AnnotationMarker
{
    /// <summary>
    /// Additional CSS classes to append to the marker
    /// </summary>
    public string CssClass { get; set; }

    /// <summary>
    /// Fill Color of the marker point.
    /// </summary>
    public Color FillColor { get; set; }

    /// <summary>
    /// Sets the left offset of the marker
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the marker
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Radius of the marker (applies to square shape)
    /// </summary>
    public double? Radius { get; set; }

    /// <summary>
    /// Shape of the marker.
    /// </summary>
    public ShapeEnum Shape { get; set; }

    /// <summary>
    /// Size of the marker.
    /// </summary>
    public double? Size { get; set; }

    /// <summary>
    /// Stroke Color of the marker point.
    /// </summary>
    public Color StrokeColor { get; set; }

    /// <summary>
    /// Stroke Size of the marker point.
    /// </summary>
    public double? StrokeWidth { get; set; }
}