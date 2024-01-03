using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// When there are multiple dataSeries in the chart, legends help to identify each dataSeries with a predefined symbol and name of the series.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/legend">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/legend">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/legend">JavaScript Reference</see>
/// </remarks>
public class Legend
{
    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public LegendContainerMargin ContainerMargin { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string TextAnchor { get; set; }

    /// <summary>
    /// The floating option will take out the legend from the chart area and make it float above the chart.
    /// </summary>
    public bool? Floating { get; set; }

    /// <summary>
    /// Sets the font-family of legend text elements
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Sets the fontSize of legend text elements
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Sets the font-weight of legend text elements
    /// </summary>
    public object FontWeight { get; set; }

    /// <summary>
    /// Sets the height for legend container
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Available options for horizontal alignment
    /// </summary>
    public Align? HorizontalAlign { get; set; }

    /// <summary>
    /// Inverse the placement ordering of the legend items.
    /// </summary>
    public bool? InverseOrder { get; set; }

    /// <inheritdoc cref="LegendItemMargin"/>
    public LegendItemMargin ItemMargin { get; set; }

    /// <inheritdoc cref="LegendLabels"/>
    public LegendLabels Labels { get; set; }

    /// <inheritdoc cref="LegendMarkers"/>
    public LegendMarkers Markers { get; set; }

    /// <summary>
    /// Sets the left offset of the marker
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the marker
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="LegendOnItemClick"/>
    public LegendOnItemClick OnItemClick { get; set; }

    /// <inheritdoc cref="LegendOnItemHover"/>
    public LegendOnItemHover OnItemHover { get; set; }

    /// <summary>
    /// Available position options for legend
    /// </summary>
    public LegendPosition? Position { get; set; }

    /// <summary>
    /// Whether to show or hide the legend container.
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// Allows you to hide a particular legend if it's series contains all null values.
    /// </summary>
    public bool? ShowForNullSeries { get; set; }

    /// <summary>
    /// Show legend even if there is just 1 series.
    /// </summary>
    public bool? ShowForSingleSeries { get; set; }

    /// <summary>
    /// Allows you to hide a particular legend if it's series contains all 0 values.
    /// </summary>
    public bool? ShowForZeroSeries { get; set; }

    /// <summary>
    /// Sets the width for legend container
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// A custom formatter function to append additional text to the legend series names. Example:
    /// 
    /// <code>
    /// legend: {
    ///     formatter: function(seriesName, opts) {
    ///         return [seriesName, " - ", opts.w.globals.series[opts.seriesIndex]]
    ///     }
    /// },
    /// </code>
    /// </summary>
    public string Formatter { get; set; }

    /// <summary>
    /// A formatter function to allow showing data values in the legend while hovering on the chart. This can be useful when you have multiple series, and you don't want to show tooltips for each series together. Example:
    /// 
    /// <code>
    /// legend: {
    ///     tooltipHoverFormatter: function(seriesName, opts) {
    ///         return seriesName + ' - &lt;strong&gt;' + opts.w.globals.series[opts.seriesIndex][opts.dataPointIndex] + '&lt;/strong&gt;'
    ///     }
    /// },
    /// </code>
    /// </summary>
    /// <remarks>
    /// Note: This feature is only available in shared tooltips (when you have <see cref="Tooltip.Shared"/>: <see langword="true"/>).
    /// </remarks>
    public string TooltipHoverFormatter { get; set; }

    /// <summary>
    /// Allows you to overwrite the default legend items with this customized set of labels. Please note that the click/hover events of the legend will stop working if you provide these custom legend labels.
    /// </summary>
    public List<string> CustomLegendItems { get; set; }
}