using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

public class Chart
{
    /// <summary>
    /// Indicates if only bar series should be stacked. Valid in mixed charts
    /// </summary>
    public bool? StackOnlyBar { get; set; }

    /// <inheritdoc cref="Models.Animations" />
    public Animations Animations { get; set; }

    /// <summary>
    /// Background color for the chart area. If you want to set background with css, use .apexcharts-canvas to set it.
    /// </summary>
    public Color Background { get; set; }

    /// <inheritdoc cref="Models.Brush" />
    public Brush Brush { get; set; }

    /// <summary>
    /// defaultLocale is the preselected language that the chart should render initially and the selected locale has to be present in the locales array. Read more in the <see href="https://apexcharts.com/docs/localization">localization</see> guide.
    /// </summary>
    public string DefaultLocale { get; set; }

    /// <inheritdoc cref="Models.DropShadow" />
    public DropShadow DropShadow { get; set; }

    /// <summary>
    /// A collection of JavaScript functions to execute on specific interations with the chart. Recommendation is to use events within <see cref="ApexChart{TItem}"/>. Available keys are:
    /// 
    /// animationEnd,
    /// beforeMount,
    /// mounted,
    /// updated,
    /// click,
    /// mouseMove,
    /// mouseLeave,
    /// legendClick,
    /// markerClick,
    /// xAxisLabelClick,
    /// selection,
    /// dataPointSelection,
    /// dataPointMouseEnter,
    /// dataPointMouseLeave,
    /// beforeZoom,
    /// beforeResetZoom,
    /// zoomed,
    /// scrolled,
    /// brushScrolled
    /// </summary>
    /// <remarks>
    /// <see href="https://apexcharts.com/docs/options/chart/events">JavaScript Reference</see>
    /// </remarks>
    public Dictionary<string, object> Events { get; set; }

    /// <summary>
    /// Sets the font family for all the text elements of the chart. Defaults to 'Helvetica, Arial, sans-serif'
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Sets the text color for the chart. Defaults to #373d3f
    /// </summary>
    public Color ForeColor { get; set; }

    /// <summary>
    /// A chart group is created to perform interactive operations at the same time in all the charts. In case you want to create <see href="https://apexcharts.com/docs/chart-types/synchronized-charts">synchronized charts</see>, you will need to provide this property.
    /// </summary>
    public string Group { get; set; }

    /// <summary>
    /// A chart ID is a unique identifier that will be used in calling certain ApexCharts methods. You will also need chart.id to be set in case you want to use any of the following functionalities.
    /// 
    /// <list type="bullet">
    /// <item><see href="https://apexcharts.com/docs/options/chart/brush">brush chart</see></item>
    /// <item><see href="https://apexcharts.com/docs/chart-types/synchronized-charts">synchronized chart</see></item>
    /// <item>Calling <see href="https://apexcharts.com/docs/methods/#exec">exec</see> method of ApexCharts</item>
    /// </list>
    /// </summary>
    public string Id { get; set; }

    /// <inheritdoc cref="ChartLocale" />
    public List<ChartLocale> Locales { get; set; }

    /// <summary>
    /// Sets the left offset for the whole chart.
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for the entire chart.
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// A small increment in height added to the parent of chart element.
    /// </summary>
    public double? ParentHeightOffset { get; set; }

    /// <summary>
    /// Re-render the chart when the element size gets changed or the size of the parent element gets changed. Useful in conditions where the chart container resizes after page reload.
    /// </summary>
    public bool? RedrawOnParentResize { get; set; }

    /// <summary>
    /// Re-render the chart when the window in which chart is rendered gets resized. Useful when rendering chart in iframes.
    /// </summary>
    public bool? RedrawOnWindowResize { get; set; }

    /// <inheritdoc cref="Models.Selection" />
    public Selection Selection { get; set; }

    /// <inheritdoc cref="ChartSparkline" />
    public ChartSparkline Sparkline { get; set; }

    /// <summary>
    /// Enables stacked option for axis charts. <see href="https://apexcharts.com/javascript-chart-demos/column-charts/stacked">Example</see>
    /// </summary>
    /// <remarks>
    /// A stacked chart works only for same chart types and won't work in combo/mixed charts combinations. So, an area series combined with a column series will not work.
    /// </remarks>
    public bool? Stacked { get; set; }

    /// <summary>
    /// When stacked, should the stacking be percentage based or normal stacking.
    /// </summary>
    public StackType? StackType { get; set; }

    /// <inheritdoc cref="Models.Toolbar" />
    public Toolbar Toolbar { get; set; }

    /// <summary>
    /// Specify the chart type
    /// </summary>
    public ChartTypes? Type { get; set; }

    /// <summary>
    /// Width of the chart.
    /// </summary>
    /// <remarks>
    /// Accepts Number (400) OR String ('400px')
    /// </remarks>
    public object Width { get; set; }

    /// <summary>
    /// Height of the chart. The default value 'auto' is calculated based on the golden ratio 1.618 which roughly translates to a 16:10 aspect ratio. Examples:
    /// 
    /// <code>
    /// height: 400 
    /// height: '400px' 
    /// height: '100%' 
    /// </code>
    /// </summary>
    /// <remarks>
    /// Note: If you provide a percentage value '100%', make sure to have a fixed height parent.
    /// </remarks>
    public object Height { get; set; }

    /// <inheritdoc cref="Models.Zoom" />
    public Zoom Zoom { get; set; }
}