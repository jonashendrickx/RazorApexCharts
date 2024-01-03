namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the columns for the grid
/// </summary>
public class GridColumn
{
    /// <summary>
    /// Grid background colors filling in column pattern. Each column will be filled with colors based on the index in this array. If less colors are specified, colors are repeated.
    /// </summary>
    public List<Color> Colors { get; set; }

    /// <summary>
    /// Opacity of the column background colors. Accepts values from 0 to 1
    /// </summary>
    public double? Opacity { get; set; }
}