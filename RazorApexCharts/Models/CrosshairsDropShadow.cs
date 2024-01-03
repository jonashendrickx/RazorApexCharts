namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style a shadow to display with the crosshairs
/// </summary>
public class CrosshairsDropShadow
{
    /// <summary>
    /// Set blur distance for shadow
    /// </summary>
    public double? Blur { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Enable a dropshadow for crosshairs
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
}