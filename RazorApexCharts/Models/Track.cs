namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the empty portions of the radial bar chart
/// </summary>
public class Track
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Color of the track.
    /// </summary>
    public Color Background { get; set; }

    /// <inheritdoc cref="Models.DropShadow" />
    public DropShadow DropShadow { get; set; }

    /// <summary>
    /// Angle to which the track should end.
    /// </summary>
    public double? EndAngle { get; set; }

    /// <summary>
    /// Spacing between each track
    /// </summary>
    public double? Margin { get; set; }

    /// <summary>
    /// Opacity of the track
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Show track under the bar lines.
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// Angle from which the track should start.
    /// </summary>
    public double? StartAngle { get; set; }

    /// <summary>
    /// Please use <see cref="Width"/>
    /// </summary>
    [Obsolete("This property is obsolete. Use Width instead.", false)]
    public string StrokeWidth { get; set; }

    /// <summary>
    /// Width of the track
    /// </summary>
    public double? Width { get; set; }
}