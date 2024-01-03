namespace RazorApexCharts.Models.DataPoints;

/// <summary>
/// Defines styling details to apply to individual data point targets
/// </summary>
public class DataPointGoal
{
    /// <summary>
    /// The name to assign to the goal
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Y-value to assign to the goal
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Sets the width of the goal marker
    /// </summary>
    public int? StrokeWidth { get; set; }

    /// <summary>
    /// Sets the height of the goal marker
    /// </summary>
    public int? StrokeHeight { get; set; }

    /// <summary>
    /// Sets the spacing between ticks on a dashed goal marker
    /// </summary>
    public int? StrokeDashArray { get; set; }

    /// <summary>
    /// Sets the color of the goal marker
    /// </summary>
    public Color StrokeColor { get; set; }

    /// <summary>
    /// The shape to use for the goal marker
    /// </summary>
    public LineCap? StrokeLineCap { get; set; }
}