using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options to use when filling a chart with a pattern
/// </summary>
public class FillPattern
{
    /// <summary>
    /// Pattern height which will be repeated at this interval
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Pattern lines width indicates the thickness of the stroke of pattern.
    /// </summary>
    public double? StrokeWidth { get; set; }

    /// <inheritdoc cref="FillPatternStyleSelections"/>
    /// <summary>
    /// The type of pattern to fill the chart with
    /// </summary>
    public FillPatternStyleSelections Style { get; set; }

    /// <summary>
    /// Pattern width which will be repeated at this interval
    /// </summary>
    public double? Width { get; set; }
}