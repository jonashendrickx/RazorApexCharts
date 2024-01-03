namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling to apply to the border of an axis
/// </summary>
public class AxisBorder
{
    /// <summary>
    /// Color of the axis border
    /// </summary>
    [JsonPropertyName("color")]
    public Color Color { get; set; }

    /// <summary>
    /// Sets the border height of the axis line
    /// </summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }
    
    /// <summary>
    /// Sets the left offset of the axis border
    /// </summary>
    [JsonPropertyName("offsetX")]
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset of the axis border
    /// </summary>
    [JsonPropertyName("offsetY")]
    public double? OffsetY { get; set; }
    
    /// <summary>
    /// Draw a border on the axis
    /// </summary>
    [JsonPropertyName("show")]
    public bool? Show { get; set; }

    /// <summary>
    /// Sets the width of the axis line
    /// </summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}