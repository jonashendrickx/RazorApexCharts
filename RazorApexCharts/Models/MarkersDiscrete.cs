namespace RazorApexCharts.Models;

/// <summary>
/// Allows you to target individual data-points and style particular markers differently
/// </summary>
public class MarkersDiscrete
{
    /// <summary>
    /// The index of the marker to apply styling to
    /// </summary>
    public double? DataPointIndex { get; set; }

    /// <summary>
    /// The color to fill the marker with
    /// </summary>
    public string FillColor { get; set; }

    /// <summary>
    /// The index within the data series to apply styling to
    /// </summary>
    public double? SeriesIndex { get; set; }

    /// <summary>
    /// The size to apply to the marker
    /// </summary>
    public double? Size { get; set; }

    /// <summary>
    /// The stroke color to apply to the marker
    /// </summary>
    public string StrokeColor { get; set; }

    /// <summary>
    /// The type of shape to use for the marker
    /// </summary>
    public ShapeEnum? Shape { get; set; }
}