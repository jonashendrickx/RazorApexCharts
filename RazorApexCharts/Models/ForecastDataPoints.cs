namespace RazorApexCharts.Models;

/// <summary>
/// Class to define how additional data points that extrapolate the provided data should be generated
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/forecastdatapoints">JavaScript Reference</see>
/// </remarks>
public class ForecastDataPoints
{
    /// <summary>
    /// Number of ending data-points you want to indicate as a forecast or prediction values. The ending line/bar will result into a dashed border with a distinct look to differentiate from the rest of the data-points.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Opacity of the fill attribute.
    /// </summary>
    public double? FillOpacity { get; set; }

    /// <summary>
    /// Sets the width of the border (applies to line/area/bar/boxplots).
    /// </summary>
    public double? StrokeWidth { get; set; }

    /// <summary>
    /// Creates dashes in borders of SVG path. Higher number creates more space between dashes in the border.
    /// </summary>
    public double? DashArray { get; set; }
}