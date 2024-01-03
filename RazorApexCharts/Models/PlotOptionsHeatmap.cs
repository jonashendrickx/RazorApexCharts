namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Heatmap"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/heatmap-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/heatmap-chart">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/heatmap">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsHeatmap
{
    /// <inheritdoc cref="PlotOptionsHeatmapColorScale" />
    public PlotOptionsHeatmapColorScale ColorScale { get; set; }

    /// <summary>
    /// When turned on, each row in a heatmap will have it's own lowest and highest range and colors will be shaded for each series. Default value is turned off.
    /// </summary>
    public bool? Distributed { get; set; }

    /// <summary>
    /// Enable different shades of color depending on the value
    /// </summary>
    public bool? EnableShades { get; set; }

    /// <summary>
    /// Radius of the rectangle inside heatmap
    /// </summary>
    public double? Radius { get; set; }

    /// <summary>
    /// When enabled, it will reverse the shades for negatives but keep the positive shades as it is now. An example of such use-case would be in a profit/loss chart where darker reds mean larger losses, darker greens mean larger gains.
    /// </summary>
    public bool? ReverseNegativeShade { get; set; }

    /// <summary>
    /// The intensity of the shades generated for each value. Accepts from 0 to 1
    /// </summary>
    public double? ShadeIntensity { get; set; }

    /// <summary>
    /// If turned on, the stroke/border around the heatmap cell has the same color as the cell color.
    /// </summary>
    public bool? UseFillColorAsStroke { get; set; }
}