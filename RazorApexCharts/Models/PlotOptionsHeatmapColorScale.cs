namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to color datapoints on the heatmap chart
/// </summary>
public class PlotOptionsHeatmapColorScale
{
    /// <summary>
    /// In a multiple series heatmap, flip the color-scale to fill the heatmaps vertically instead of horizontally.
    /// </summary>
    public bool? Inverse { get; set; }

    /// <summary>
    /// Specify the higher range for heatmap color calculation.
    /// </summary>
    public double? Max { get; set; }

    /// <summary>
    /// Specify the lower range for heatmap color calculation.
    /// </summary>
    public double? Min { get; set; }

    /// <inheritdoc cref="PlotOptionsHeatmapColorScaleRange" />
    public List<PlotOptionsHeatmapColorScaleRange> Ranges { get; set; }
}