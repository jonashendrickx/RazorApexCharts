using System.Drawing;
using RazorApexCharts.Models.MultiType;

namespace RazorApexCharts.Models;

/// <summary>
/// Class to define how lines on charts should be generated.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/options/stroke">JavaScript Reference</see>
/// </remarks>
public class Stroke
{
    /// <summary>
    /// Colors to fill the border for paths.
    /// </summary>
    public List<Color> Colors { get; set; }

    /// <inheritdoc cref="CurveSelections"/>
    /// <summary>
    /// In line / area charts, whether to draw smooth lines or straight lines.
    /// </summary>
    public CurveSelections Curve { get; set; }

    /// <inheritdoc cref="Size"/>
    /// <summary>
    /// Creates dashes in borders of svg path. Higher number creates more space between dashes in the border.
    /// </summary>
    public Size DashArray { get; set; }

    /// <summary>
    /// For setting the starting and ending points of stroke
    /// </summary>
    public LineCap? LineCap { get; set; }

    /// <summary>
    /// To show or hide path-stroke / line
    /// </summary>
    public bool Show { get; set; } = true;

    /// <inheritdoc cref="Size"/>
    /// <summary>
    /// Sets the width of border for svg path
    /// </summary>
    public Size Width { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Fill Fill { get; set; }
}