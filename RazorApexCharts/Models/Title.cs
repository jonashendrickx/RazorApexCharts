using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define the visual appearance of the title assigned to the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/title">JavaScript Reference</see>
/// </remarks>
public class Title
{
    /// <summary>
    /// Alignment of title relative to chart area.
    /// </summary>
    public Align? Align { get; set; }

    /// <summary>
    /// The floating option will take out the title text from the chart area and make it float on top of the chart.
    /// </summary>
    public bool? Floating { get; set; }

    /// <summary>
    /// Vertical spacing around the title text
    /// </summary>
    public double? Margin { get; set; }

    /// <summary>
    /// Sets the left offset for title text
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for title text
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="TitleStyle" />
    public TitleStyle Style { get; set; }

    /// <summary>
    /// Text to display as a title of chart
    /// </summary>
    public string Text { get; set; }
}