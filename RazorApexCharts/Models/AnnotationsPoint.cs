namespace RazorApexCharts.Models;

/// <summary>
/// Defines details for individual data annotation points
/// </summary>
public class AnnotationsPoint
{
    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string Id { get; set; }

    /// <inheritdoc cref="AnnotationsPointImage" />
    public AnnotationsPointImage Image { get; set; }

    /// <inheritdoc cref="Models.Label" />
    public Label Label { get; set; }

    /// <inheritdoc cref="AnnotationMarker" />
    public AnnotationMarker Marker { get; set; }

    /// <summary>
    /// In a multiple series, you will have to specify which series the annotation's y value belongs to. Not required for single series
    /// </summary>
    public double? SeriesIndex { get; set; }

    /// <summary>
    /// X Value on which the annotation will be drawn (can be either timestamp for datetime x-axis or string category for category x-axis)
    /// </summary>
    public object X { get; set; }

    /// <summary>
    /// Y Value on which the annotation will be drawn
    /// </summary>
    public double? Y { get; set; }

    /// <summary>
    /// When there are multiple y-axis, setting this options will put the point annotation for that particular y-axis' y value
    /// </summary>
    public double? YAxisIndex { get; set; }
}