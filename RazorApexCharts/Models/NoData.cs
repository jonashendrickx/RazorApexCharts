using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define information to display when no data is available for the chart. Useful when loading data from external sources.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/chart-data">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/options/nodata">JavaScript Reference</see>
/// </remarks>
public class NoData
{
    /// <summary>
    /// Determines where to display the loading message
    /// </summary>
    public Align? Align { get; set; }

    /// <summary>
    /// Text offset from left
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Text offset from top
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="NoDataStyle"/>
    public NoDataStyle Style { get; set; }

    /// <summary>
    /// The text to display when no-data is available. Defaults to undefined which displays nothing.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Determines where to display the loading message
    /// </summary>
    public VerticalAlign? VerticalAlign { get; set; }
}