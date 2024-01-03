namespace RazorApexCharts.Models;

/// <summary>
/// Defines options for animations that run individually
/// </summary>
public class AnimateGradually
{
    /// <summary>
    /// Speed at which gradual (one by one) animation runs.
    /// </summary>
    public double? Delay { get; set; }

    /// <summary>
    /// Gradually animate one by one every data in the series instead of animating all at once.
    /// </summary>
    public bool Enabled { get; set; } = true;
}