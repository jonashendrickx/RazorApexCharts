namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling to apply to legend item markers
/// </summary>
public class LegendMarkers
{
    /// <summary>
    /// Fill Colors of the marker point.
    /// </summary>
    public List<Color> FillColors { get; set; }

    /// <summary>
    /// Height of the marker.
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Sets the left offset of the marker
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the marker
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Border Radius of the marker
    /// </summary>
    public double? Radius { get; set; }

    /// <summary>
    /// Stroke Color of the marker point.
    /// </summary>
    public string StrokeColor { get; set; }

    /// <summary>
    /// Stroke Size of the marker point.
    /// </summary>
    public double? StrokeWidth { get; set; }

    /// <summary>
    /// Width of the marker that appears before series name.
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// Custom HTML element to put in place of marker.
    /// 
    /// <code>
    /// markers: {
    ///     customHTML: function() {
    ///         return '&lt;span class="custom-marker"&gt;&lt;i class="fas fa-chart-pie"&gt;&lt;/i&gt;&lt;/span&gt;'
    ///     }
    /// }
    /// </code>
    /// </summary>
    public string CustomHTML { get; set; }
}