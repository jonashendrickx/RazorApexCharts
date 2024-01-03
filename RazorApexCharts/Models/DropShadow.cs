namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style a drop shadow for current object
/// </summary>
public class DropShadow
{
    /// <summary>
    /// Set blur distance for shadow
    /// </summary>
    public double? Blur { get; set; }

    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Give a color to the shadow.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Enable a dropshadow for paths of the SVG
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Set left offset for shadow
    /// </summary>
    public double? Left { get; set; }

    /// <summary>
    /// Set the opacity of shadow.
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Set top offset for shadow
    /// </summary>
    public double? Top { get; set; }

    /// <summary>
    /// Provide series index on which the dropshadow should be enabled.
    /// </summary>
    public List<double> EnabledOnSeries { get; set; }
}