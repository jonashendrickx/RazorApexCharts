namespace RazorApexCharts.Models.Enums;

/// <summary>
/// A list of ways to generate lines
/// </summary>

public enum Curve
{
    /// <summary>
    /// Connects the points in a curve fashion. Also known as spline
    /// </summary>
    Smooth,

    /// <summary>
    /// Points are connected by horizontal and vertical line segments, looking like steps of a staircase.
    /// </summary>
    Stepline,

    /// <summary>
    /// Connect the points in straight lines.
    /// </summary>
    Straight
};