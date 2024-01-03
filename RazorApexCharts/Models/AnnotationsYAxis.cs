namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the Y-Axis for a data annotation point
/// </summary>
public class AnnotationsYAxis
{
    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Color of the annotation line
    /// </summary>
    public Color BorderColor { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <summary>
    /// Fill Color of the region. Only applicable if <see cref="Y2"/> is provided.
    /// </summary>
    public Color FillColor { get; set; }

    /// <inheritdoc cref="Models.Label" />
    public Label Label { get; set; }

    /// <summary>
    /// Sets the left offset for annotation line
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for annotation line
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Opacity of the filled region.
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Creates dashes in borders of the SVG path. A higher number creates more space between dashes in the border.
    /// </summary>
    public double? StrokeDashArray { get; set; }

    /// <summary>
    /// Sets the width for annotation line
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// Value on which the annotation will be drawn
    /// </summary>
    public object Y { get; set; }

    /// <summary>
    /// If you provide this additional y2 value, a region will be drawn from y to y2.
    /// </summary>
    public object Y2 { get; set; }

    /// <summary>
    /// When there are multiple y-axis, setting this options will put the annotation for that particular y-axis
    /// </summary>
    public double? YAxisIndex { get; set; }
}