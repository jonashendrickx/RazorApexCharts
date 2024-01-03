namespace RazorApexCharts.Models;

/// <summary>
/// Defines colors to apply to the box plot chart
/// </summary>
public class BloxPlotColors
{
    /// <summary>
    /// Color for the upper quartile (Q3 to median) of the box plot.
    /// </summary>
    public Color Upper { get; set; }

    /// <summary>
    /// Color for the lower quartile (median to Q1) of the box plot.
    /// </summary>
    public Color Lower { get; set; }
}