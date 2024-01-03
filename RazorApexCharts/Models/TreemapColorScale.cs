namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to color a given section of the treemap chart.
/// </summary>
public class TreemapColorScale
{
    /// <summary>
    /// In a multiple series treemap, flip the color-scale to fill the treemaps vertically instead of horizontally.
    /// </summary>
    public bool? Inverse { get; set; }

    /// <inheritdoc cref="TreemapRanges" />
    public List<TreemapRanges> Ranges { get; set; }

    /// <summary>
    /// Specify the lower range for treemap color calculation.
    /// </summary>
    public double? Min { get; set; }

    /// <summary>
    /// Specify the higher range for treemap color calculation.
    /// </summary>
    public double? Max { get; set; }
}