namespace RazorApexCharts.Models;

/// <summary>
/// Defines details for images to use on the data annotations
/// </summary>
public class AnnotationsImage
{
    /// <summary>
    /// A query selector to which the image element will be appended.
    /// </summary>
    public string AppendTo { get; set; }

    /// <summary>
    /// The height of the image
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// The height of the image
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// The width of the image
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// Left position for the image relative to the element specified in <see cref="AppendTo"/> property
    /// </summary>
    public double? X { get; set; }

    /// <summary>
    /// Top position for the image relative to the element specified in <see cref="AppendTo"/> property
    /// </summary>
    public double? Y { get; set; }
}