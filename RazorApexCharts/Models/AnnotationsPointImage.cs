namespace RazorApexCharts.Models;

/// <summary>
/// Defines details for an image to use with an individual data annotation point
/// </summary>
public class AnnotationsPointImage
{
    /// <summary>
    /// Height of image annotation.
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Left offset of the image.
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Top offset of the image.
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// Provide a full path of the image to display in place of annotation.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Width of image annotation.
    /// </summary>
    public double? Width { get; set; }
}