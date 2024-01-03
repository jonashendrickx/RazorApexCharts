namespace RazorApexCharts.Models;

/// <summary>
/// Defines zones to apply a color to on the heatmap chart
/// </summary>
public class PlotOptionsHeatmapColorScaleRange
{
    /// <summary>
    /// Background color to fill the range with.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Fore Color of the text if data-labels is enabled.
    /// </summary>
    public Color ForeColor { get; set; }

    /// <summary>
    /// Value indicating range's upper limit
    /// </summary>
    public double? From { get; set; }

    /// <summary>
    /// If a name is provided, it will be used in the legend. If it is not provided, the text falls back to {from} - {to}
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Value indicating range's lower limit
    /// </summary>
    public double? To { get; set; }
}