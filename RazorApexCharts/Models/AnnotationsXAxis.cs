namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the X-Axis for a data annotation point
/// </summary>
public class AnnotationsXAxis
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
    /// Sets the witdh of the line. Please note this property is missing in apexcharts.js docs.
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <summary>
    /// Fill Color of the region. Only applicable if <see cref="X2"/> is provided.
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
    /// Creates dashes in borders of SVG path. A higher number creates more space between dashes in the border.
    /// </summary>
    public double? StrokeDashArray { get; set; }

    /// <summary>
    /// Value on which the annotation will be drawn
    /// </summary>
    public object X { get; set; }

    /// <summary>
    /// If you provide this additional x2 value, a region will be drawn from x to x2.
    /// </summary>
    public object X2 { get; set; }
}