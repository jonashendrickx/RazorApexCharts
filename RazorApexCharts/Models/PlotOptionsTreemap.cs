namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Treemap"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/chart-types/treemap-chart">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/treemap">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsTreemap
{
    /// <summary>
    /// Enable different shades of color depending on the value
    /// </summary>
    public bool? EnableShades { get; set; }

    /// <summary>
    /// Enable different shades of color depending on the value. Accepts from 0 to 1
    /// </summary>
    public double? ShadeIntensity { get; set; }

    /// <summary>
    /// When turned on, each series in a treemap will have it's own lowest and highest range and colors will be shaded for each series. Default value is false.
    /// </summary>
    public bool? Distributed { get; set; }

    /// <summary>
    /// When enabled, it will reverse the shades for negatives but keep the positive shades as it is now. An example of such use-case would be in a profit/loss chart where darker reds mean larger losses, darker greens mean larger gains.
    /// </summary>
    public bool? ReverseNegativeShade { get; set; }

    /// <summary>
    /// When turned on, the stroke/border around the treemap cell has the same color as the cell color.
    /// </summary>
    public bool? UseFillColorAsStroke { get; set; }

    /// <inheritdoc cref="TreemapColorScale" />
    public TreemapColorScale ColorScale { get; set; }

    /// <inheritdoc cref="TreemapDataLabels" />
    public TreemapDataLabels DataLabels { get; set; }
}