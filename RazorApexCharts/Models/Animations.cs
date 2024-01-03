using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// ApexCharts provides a smooth experience with the help of svgjs's built in animations.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/animations">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/chart/animations">JavaScript Reference</see>
/// </remarks>
public class Animations
{
    /// <inheritdoc cref="Models.AnimateGradually" />
    public AnimateGradually AnimateGradually { get; set; }

    /// <inheritdoc cref="Models.DynamicAnimation" />
    public DynamicAnimation DynamicAnimation { get; set; }

    /// <summary>
    /// The type of animation to use
    /// </summary>
    public Easing? Easing { get; set; }

    /// <summary>
    /// Enable or disable all the animations that happen initially or during data update.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Speed at which animation runs.
    /// </summary>
    public double? Speed { get; set; }
}