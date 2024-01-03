namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Donut"/>. The <see cref="PlotOptionsPie"/> may also be used for donut charts.
/// </summary>
/// <remarks>
/// 
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/donut-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/pie-donut">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/pie">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsDonut
{
    /// <summary>
    /// The background color of the pie
    /// </summary>
    public Color Background { get; set; }

    /// <inheritdoc cref="DonutLabels" />
    public DonutLabels Labels { get; set; }

    /// <summary>
    /// Donut / ring size in percentage relative to the total pie area.
    /// </summary>
    public string Size { get; set; }
}