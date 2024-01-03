using System.Drawing;
using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define the visual appearance of the data point markers
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/markers">JavaScript Reference</see>
/// </remarks>
public class Markers
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Sets the fill color(s) of the marker point.
    /// </summary>
    public Color Colors { get; set; }

    /// <summary>
    /// Allows you to target individual data-points and style particular marker differently. Example:
    /// 
    /// <code>
    /// markers: {
    ///     discrete: [{
    ///         seriesIndex: 0,
    ///         dataPointIndex: 7,
    ///         fillColor: '#e3e3e3',
    ///         strokeColor: '#fff',
    ///         size: 5,
    ///         shape: "circle"
    ///     }, {
    ///         seriesIndex: 2,
    ///         dataPointIndex: 11,
    ///         fillColor: '#f7f4f3',
    ///         strokeColor: '#eee',
    ///         size: 4,
    ///         shape: "square"
    ///     }]
    /// }
    /// </code>
    /// </summary>
    public List<MarkersDiscrete> Discrete { get; set; }

    /// <inheritdoc cref="Opacity"/>
    /// <summary>
    /// Opacity of the marker fill color.
    /// </summary>
    public Opacity FillOpacity { get; set; }

    /// <inheritdoc cref="MarkersHover"/>
    public MarkersHover Hover { get; set; }

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
    public ShapeEnum? Shape { get; set; }

    /// <summary>
    /// Whether to show markers for null values in a line/area chart. If disabled, any null values present in line/area charts will not be visible.
    /// </summary>
    public bool? ShowNullDataPoints { get; set; }

    /// <inheritdoc cref="System.Drawing.Size"/>
    /// <summary>
    /// Size of the marker point.
    /// </summary>
    public Size Size { get; set; }

    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Stroke Color of the marker.
    /// </summary>
    public Color StrokeColors { get; set; }

    /// <inheritdoc cref="System.Drawing.Size"/>
    /// <summary>
    /// Dashes in the border around marker. Higher number creates more space between dashes in the border.
    /// </summary>
    public Size StrokeDashArray { get; set; }

    /// <inheritdoc cref="Opacity"/>
    /// <summary>
    /// Opacity of the border around marker.
    /// </summary>
    public Opacity StrokeOpacity { get; set; }

    /// <inheritdoc cref="System.Drawing.Size"/>
    /// <summary>
    /// Stroke Size of the marker.
    /// </summary>
    public Size StrokeWidth { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Size Width { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Size Height { get; set; }
}