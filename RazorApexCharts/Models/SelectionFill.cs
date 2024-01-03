namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling options for the fill of selections
/// </summary>
public class SelectionFill
{
    /// <summary>
    /// Background color of the selection rect which is drawn when user drags on the chart.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Opacity of background color of the selection rect.
    /// </summary>
    public double? Opacity { get; set; }
}