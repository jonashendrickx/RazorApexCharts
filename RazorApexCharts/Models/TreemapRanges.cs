namespace RazorApexCharts.Models;

/// <summary>
/// Defines zones and colors to apply to the treemap chart
/// </summary>
public class TreemapRanges
{
    /// <summary>
    /// Value indicating range's upper limit
    /// </summary>
    public double? From { get; set; }

    /// <summary>
    /// Value indicating range's lower limit
    /// </summary>
    public double? To { get; set; }

    /// <summary>
    /// Background color to fill the range with.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Fore Color of the text if data-labels is enabled.
    /// </summary>
    public Color ForeColor { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string Name { get; set; }
}