namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to color the bar chart
/// </summary>
public class PlotOptionsBarColors
{
    /// <summary>
    /// Custom colors for background rects. The number of colors in the array is repeated if fewer colors than data points are specified.
    /// </summary>
    public List<string> BackgroundBarColors { get; set; }

    /// <summary>
    /// Opacity for background colors of the bar
    /// </summary>
    public double? BackgroundBarOpacity { get; set; }

    /// <summary>
    /// Border radius for background rect of the bar
    /// </summary>
    public double? BackgroundBarRadius { get; set; }

    /// <inheritdoc cref="PlotOptionsBarColorRange" />
    public List<PlotOptionsBarColorRange> Ranges { get; set; }
}