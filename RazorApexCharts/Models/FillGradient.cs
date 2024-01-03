using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options to use when filling a chart with a gradient. <see href="https://codepen.io/apexcharts/pen/GQmoXP">Example</see>
/// </summary>
public class FillGradient
{
    /// <summary>
    /// Optional colors that ends the gradient to. The main colors array becomes the gradientFromColors and this array becomes the end colors of the gradient. Each index in the array corresponds to the series-index.
    /// </summary>
    public List<string> GradientToColors { get; set; }

    /// <summary>
    /// Inverse the start and end colors of the gradient.
    /// </summary>
    public bool? InverseColors { get; set; }

    /// <inheritdoc cref="Opacity"/>
    /// <summary>
    /// Start color's opacity.
    /// </summary>
    public Opacity OpacityFrom { get; set; }

    /// <inheritdoc cref="Opacity"/>
    /// <summary>
    /// End color's opacity
    /// </summary>
    public Opacity OpacityTo { get; set; }

    /// <summary>
    /// The option to use for shading the gradient
    /// </summary>
    public GradientShade? Shade { get; set; }

    /// <summary>
    /// Intensity of the gradient shade. Accepts from 0 to 1
    /// </summary>
    public double? ShadeIntensity { get; set; }

    /// <summary>
    /// Stops defines the ramp of colors to use on a gradient
    /// </summary>
    public List<double> Stops { get; set; }

    /// <summary>
    /// The type of gradient to generate
    /// </summary>
    public GradientType Type { get; set; }

    /// <inheritdoc cref="FillGradientStops"/>
    public List<FillGradientStops> ColorStops { get; set; }
}