using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling to apply to the ticks of an axis
/// </summary>
public class AxisTicks
{
    /// <summary>
    /// The type of border to apply
    /// </summary>
    public BorderType BorderType { get; set; }

    /// <summary>
    /// Color of the ticks
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Height of the ticks
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Sets the left offset of the ticks
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the ticks
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Draw ticks on the axis to specify intervals
    /// </summary>
    public bool? Show { get; set; }
}