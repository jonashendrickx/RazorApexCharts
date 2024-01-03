using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define the visual appearance of the subtitle assigned to the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/subtitle">JavaScript Reference</see>
/// </remarks>
public class Subtitle
{
    /// <summary>
    /// Alignment of subtitle relative to chart area.
    /// </summary>
    public Align? Align { get; set; }

    /// <summary>
    /// The floating option will take out the subtitle text from the chart area and make it float on top of the chart.
    /// </summary>
    public bool? Floating { get; set; }

    /// <summary>
    /// Vertical spacing around the subtitle text
    /// </summary>
    public double? Margin { get; set; }

    /// <summary>
    /// Sets the left offset for subtitle text
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for subtitle text
    /// </summary>
    public double? OffsetY { get; set; }

    /// <inheritdoc cref="SubtitleStyle" />
    public SubtitleStyle Style { get; set; }

    /// <summary>
    /// Text to display as a subtitle of chart
    /// </summary>
    public string Text { get; set; }
}