namespace RazorApexCharts.Models;

/// <summary>
/// Sets the portion of the bar chart to color
/// </summary>
public class PlotOptionsBarColorRange
{
    /// <summary>
    /// Color to fill the range with
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Value indicating range's upper limit
    /// </summary>
    public double? From { get; set; }

    /// <summary>
    /// Value indicating range's lower limit
    /// </summary>
    public double? To { get; set; }
}