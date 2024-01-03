namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to the axis title
/// </summary>
public class AxisTitle
{
    /// <summary>
    /// Sets the left offset for axis title.
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for the axis title.
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Rotate the axis title either 90 or -90.
    /// </summary>
    public double? Rotate { get; set; }

    /// <inheritdoc cref="AxisTitleStyle" />
    public AxisTitleStyle Style { get; set; }

    /// <summary>
    /// Give the axis a title which will be displayed below the axis labels by default.
    /// </summary>
    public string Text { get; set; }
}