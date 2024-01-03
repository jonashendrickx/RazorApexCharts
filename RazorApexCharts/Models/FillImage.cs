using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options to use when filling a chart with an image
/// </summary>
public class FillImage
{
    /// <summary>
    /// Height of each image for all the series
    /// </summary>
    public double? Height { get; set; }

    /// <inheritdoc cref="ImagePaths"/>
    /// <summary>
    /// The URL for each image to fill the chart series with
    /// </summary>
    public ImagePaths Src { get; set; }

    /// <summary>
    /// Width of each image for all the series
    /// </summary>
    public double? Width { get; set; }
}