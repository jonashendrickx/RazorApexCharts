namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to create a fixed-position tooltip
/// </summary>
public class TooltipFixed
{
    /// <summary>
    /// Set the tooltip to a fixed position
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Sets the left offset for the tooltip container in fixed position
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for the tooltip container in fixed position
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// When having a fixed tooltip, select a predefined position.
    /// </summary>
    public TooltipPosition Position { get; set; } = TooltipPosition.TopRight;
}