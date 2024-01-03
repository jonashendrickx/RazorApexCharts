namespace RazorApexCharts.Models;

/// <summary>
/// Defines the margin to apply to legend items
/// </summary>
public class LegendItemMargin
{
    /// <summary>
    /// Horizontal margin for individual legend item.
    /// </summary>
    public double? Horizontal { get; set; }

    /// <summary>
    /// Vertical margin for individual legend item.
    /// </summary>
    public double? Vertical { get; set; }
}