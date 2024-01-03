namespace RazorApexCharts.Models;

/// <summary>
/// Defines a styling to fill the crosshairs with
/// </summary>
public class CrosshairsFill
{
    /// <summary>
    /// Fill color of crosshairs
    /// </summary>
    public Color Color { get; set; }

    /// <inheritdoc cref="FluffyGradient" />
    public FluffyGradient Gradient { get; set; }

    /// <summary>
    /// The type of fill to use in the crosshairs
    /// </summary>
    /// <remarks>
    /// Must use either <see cref="FillType.Solid"/> or <see cref="FillType.Gradient"/>
    /// </remarks>
    public FillType Type { get; set; }
}