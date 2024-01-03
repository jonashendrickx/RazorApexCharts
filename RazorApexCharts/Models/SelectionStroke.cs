namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling options for the stroke of selections
/// </summary>
public class SelectionStroke
{
    /// <summary>
    /// Colors of selection border.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Creates dashes in borders of svg path. Higher number creates more space between dashes in the border.
    /// </summary>
    public double? DashArray { get; set; }

    /// <summary>
    /// Opacity of selection border.
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Border thickness of the selection rect.
    /// </summary>
    public double? Width { get; set; }
}