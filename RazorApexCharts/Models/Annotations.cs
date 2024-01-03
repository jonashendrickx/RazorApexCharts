namespace RazorApexCharts.Models;

/// <summary>
/// Annotations in ApexCharts allows you to write custom text on specific data-points or on axes values.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/annotations">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/annotations">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/annotations">JavaScript Reference</see>
/// </remarks>
public class Annotations
{
    /// <inheritdoc cref="AnnotationsImage" />
    public List<AnnotationsImage> Images { get; set; }

    /// <inheritdoc cref="AnnotationsPoint" />
    public List<AnnotationsPoint> Points { get; set; }

    /// <inheritdoc cref="AnnotationsText" />
    public List<AnnotationsText> Texts { get; set; }

    /// <inheritdoc cref="AnnotationsXAxis" />
    public List<AnnotationsXAxis> Xaxis { get; set; }

    /// <inheritdoc cref="AnnotationsYAxis" />
    public List<AnnotationsYAxis> Yaxis { get; set; }
}