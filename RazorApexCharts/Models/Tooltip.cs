namespace RazorApexCharts.Models;

/// <summary>
/// Tooltip allows you to preview data when user hovers over the chart area.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/tooltip">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/tooltip">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/tooltip">JavaScript Reference</see>
/// </remarks>
public class Tooltip
{
    public bool? HideEmptySeries { get; set; }

    public bool? HideEmptyShared { get; set; }

    /// <inheritdoc cref="CustomFunction"/>
    /// <summary>
    /// Draw a custom html tooltip instead of the default one based on the values provided in the function arguments.
    /// </summary>
    public CustomFunction Custom { get; set; }

    /// <summary>
    /// Show tooltip when user hovers over chart area.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Show tooltip only on certain series in a multi-series chart. Provide indices of those series which you would like to be shown.
    /// </summary>
    public List<double> EnabledOnSeries { get; set; }

    /// <summary>
    /// When enabled, fill the tooltip background with the corresponding series color
    /// </summary>
    public bool? FillSeriesColor { get; set; }

    /// <inheritdoc cref="TooltipFixed" />
    public TooltipFixed Fixed { get; set; }

    /// <summary>
    /// Follow user's cursor position instead of putting tooltip on actual data points.
    /// </summary>
    public bool? FollowCursor { get; set; }

    /// <summary>
    /// Show tooltip only when user hovers exactly over datapoint.
    /// </summary>
    public bool? Intersect { get; set; }

    /// <summary>
    /// In multiple series, when having shared tooltip, inverse the order of series (for better comparison in stacked charts).
    /// </summary>
    public bool? InverseOrder { get; set; }

    /// <inheritdoc cref="TooltipItems" />
    public TooltipItems Items { get; set; }

    /// <inheritdoc cref="TooltipMarker" />
    public TooltipMarker Marker { get; set; }

    /// <inheritdoc cref="TooltipOnDatasetHover" />
    public TooltipOnDatasetHover OnDatasetHover { get; set; }

    /// <summary>
    /// When having multiple series, show a shared tooltip. If you have a DateTime x-axis and multiple series chart ‐ make sure all your series has the same "x" values for a shared tooltip to work smoothly.
    /// </summary>
    public bool? Shared { get; set; }

    /// <inheritdoc cref="TooltipStyle" />
    public TooltipStyle Style { get; set; }

    /// <summary>
    /// The theme to apply to tooltips. If you further want to customize different background and forecolor of the tooltip, you should do it in CSS. Example:
    /// 
    /// <code>
    /// .apexcharts-tooltip {
    ///     background: #f3f3f3;
    ///     color: orange;
    /// }
    /// </code>
    /// </summary>
    public Mode? Theme { get; set; }

    /// <inheritdoc cref="TooltipX" />
    public TooltipX X { get; set; }

    /// <inheritdoc cref="TooltipY" />
    public TooltipY Y { get; set; }

    /// <inheritdoc cref="TooltipZ" />
    public TooltipZ Z { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string CssClass { get; set; }
}