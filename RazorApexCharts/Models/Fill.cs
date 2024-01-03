using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define how the generated chart will be styled.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/fill">JavaScript Reference</see>
/// </remarks>
public class Fill
{
    /// <summary>
    /// Colors to fill the svg paths. Each index in the array corresponds to the series-index. Example:
    /// 
    /// <code>
    /// fill: {
    ///     colors: ['#1A73E8', '#B32824']
    /// }
    /// </code>
    /// 
    /// Alternatively, if you are rendering a bar/pie/donut/radialBar chart, you can pass a function which returns color based on value. Example:
    /// 
    /// <code>
    /// fill: {
    ///     colors: [function({ value, seriesIndex, w }) {
    ///         if(value &lt; 55) {
    ///             return '#7E36AF'
    ///         } else if (value &gt;= 55 &amp;&amp; value &lt; 80) {
    ///             return '#164666'
    ///         } else {
    ///             return '#D9534F'
    ///         }
    ///     }]
    /// }
    /// </code>
    /// </summary>
    public List<Color> Colors { get; set; }

    /// <inheritdoc cref="FillGradient"/>
    public FillGradient Gradient { get; set; }

    /// <inheritdoc cref="FillImage"/>
    public FillImage Image { get; set; }

    /// <inheritdoc cref="MultiType.Opacity"/>
    /// <summary>
    /// Opacity of the fill attribute.
    /// </summary>
    public Opacity Opacity { get; set; }

    /// <inheritdoc cref="FillPattern"/>
    public FillPattern Pattern { get; set; }

    /// <inheritdoc cref="ApexCharts.FillTypeSelections"/>
    /// <summary>
    /// Whether to fill the paths with solid colors or gradient.
    /// </summary>
    public FillTypeSelections Type { get; set; }
}