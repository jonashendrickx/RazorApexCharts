namespace RazorApexCharts.Models;

/// <summary>
/// Grid is the plot area excluding legends, title, subtitle, x-axis, and y-axis. Grid's coordinates are used extensively in calculations in the chart in determining where to plot the actual chart elements.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/grid">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/grid">JavaScript Reference</see>
/// </remarks>
public class Grid
{
    /// <summary>
    /// Colors of grid borders / lines
    /// </summary>
    public string BorderColor { get; set; }

    /// <inheritdoc cref="GridColumn"/>
    public GridColumn Column { get; set; }

    /// <inheritdoc cref="Models.Padding"/>
    public Padding Padding { get; set; }

    /// <summary>
    /// Whether to place grid behind chart paths of in front.
    /// </summary>
    public GridPosition? Position { get; set; }

    /// <inheritdoc cref="GridRow"/>
    public GridRow Row { get; set; }

    /// <summary>
    /// To show or hide grid area (including xaxis / yaxis)
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// Creates dashes in borders of svg path. Higher number creates more space between dashes in the border.
    /// </summary>
    public double? StrokeDashArray { get; set; }

    /// <inheritdoc cref="GridXAxis"/>
    public GridXAxis Xaxis { get; set; }

    /// <inheritdoc cref="GridYAxis"/>
    public GridYAxis Yaxis { get; set; }
}