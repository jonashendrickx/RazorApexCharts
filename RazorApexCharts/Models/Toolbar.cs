using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines options for the toolbar to display in the top-right of the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/chart/toolbar">JavaScript Reference</see>
/// </remarks>
public class Toolbar
{
    /// <summary>
    /// Automatically select one of the following tools when the chart loads.
    /// </summary>
    public AutoSelected? AutoSelected { get; set; }

    /// <summary>
    /// Sets the left offset of the toolbar.
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the toolbar.
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Display the toolbar / menu in the top right corner.
    /// </summary>
    public bool Show { get; set; } = true;

    /// <inheritdoc cref="Models.Tools" />
    public Tools Tools { get; set; }

    /// <inheritdoc cref="ExportOptions" />
    public ExportOptions Export { get; set; }
}