namespace RazorApexCharts.Models;

/// <summary>
/// A list of shapes to use for starting and ending points
/// </summary>
public enum LineCap
{
    /// <summary>
    /// Ends the stroke with a 90-degree angle
    /// </summary>
    Butt,

    /// <summary>
    /// Ends the path-stroke with a radius that smooths out the start and end points
    /// </summary>
    Round,

    /// <summary>
    /// Similar to butt except that it extends the stroke beyond the length of the path
    /// </summary>
    Square
};