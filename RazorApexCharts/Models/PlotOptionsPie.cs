namespace RazorApexCharts.Models;

/// <summary>
/// Defines options specific to <see cref="ChartTypes.Pie"/>
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/pie-charts">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/chart-types/pie-donut">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/plotoptions/pie">JavaScript Reference</see>
/// </remarks>
public class PlotOptionsPie
{
    /// <summary>
    /// A custom angle from which the pie/donut slices should start.
    /// </summary>
    public double? StartAngle { get; set; }

    /// <summary>
    /// A custom angle to which the pie/donut slices should end.
    /// </summary>
    public double? EndAngle { get; set; }

    /// <summary>
    /// Transform the scale of whole pie/donut overriding the default calculations. Try variations like 0.5 and 1.5 to see how it scales based on the default width/height of the pie
    /// </summary>
    public double? CustomScale { get; set; }

    /// <inheritdoc cref="PieDataLabels" />
    /// <remarks>
    /// All additional formatting/styling settings for dataLabels has to be done in <see cref="ApexChartOptions{TItem}.DataLabels"/> configuration.
    /// </remarks>
    public PieDataLabels DataLabels { get; set; }

    /// <inheritdoc cref="PlotOptionsDonut" />
    public PlotOptionsDonut Donut { get; set; }

    /// <summary>
    /// When clicked on the pie/donut slice, expand the slice to make it distinguished visually.
    /// </summary>
    public bool? ExpandOnClick { get; set; }

    /// <summary>
    /// Sets the left offset of the whole pie area
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the whole pie area
    /// </summary>
    public double? OffsetY { get; set; }
}