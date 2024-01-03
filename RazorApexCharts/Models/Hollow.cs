namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the middle section of the radial bar chart
/// </summary>
public class Hollow
{
    /// <summary>
    /// Background color for the hollow part of the radialBars
    /// </summary>
    public Color Background { get; set; }

    /// <inheritdoc cref="Models.DropShadow" />
    public DropShadow DropShadow { get; set; }

    /// <summary>
    /// Optional image URL which can be displayed in the hollow area.
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// If true, the image doesn't exceeds the hollow area and is contained within.
    /// </summary>
    public bool? ImageClipped { get; set; }

    /// <summary>
    /// Height of the hollow image
    /// </summary>
    public double? ImageHeight { get; set; }

    /// <summary>
    /// Sets the left offset of hollow image
    /// </summary>
    public double? ImageOffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of hollow image
    /// </summary>
    public double? ImageOffsetY { get; set; }

    /// <summary>
    /// Width of the hollow image
    /// </summary>
    public double? ImageWidth { get; set; }

    /// <summary>
    /// Spacing which will be subtracted from the available hollow size
    /// </summary>
    public double? Margin { get; set; }

    /// <summary>
    /// Determines where to place the grid for the chart
    /// </summary>
    public GridPosition? Position { get; set; }

    /// <summary>
    /// Size in percentage relative to the total available size of chart
    /// </summary>
    public string Size { get; set; }
}