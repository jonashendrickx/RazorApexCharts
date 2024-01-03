namespace RazorApexCharts.Models;

/// <summary>
/// Defines a styling for a gradient to fill the crosshairs with
/// </summary>
public class FluffyGradient
{
    /// <summary>
    /// Crosshairs Gradient Color from
    /// </summary>
    public Color ColorFrom { get; set; }

    /// <summary>
    /// Crosshairs Gradient Color to
    /// </summary>
    public Color ColorTo { get; set; }

    /// <summary>
    /// Crosshairs fill opacity from
    /// </summary>
    public double? OpacityFrom { get; set; }

    /// <summary>
    /// Crosshairs fill opacity to
    /// </summary>
    public double? OpacityTo { get; set; }

    /// <summary>
    /// Stops defines the ramp of colors to use on a gradient
    /// </summary>
    public List<double> Stops { get; set; }
}