namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to  apply to the Z-axis value of a tooltip
/// </summary>
public class TooltipZ
{
    /// <summary>
    /// A custom text for the z values of Bubble Series.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// To format the z values of a Bubble series, you can use this function.
    /// </summary>
    public string Formatter { get; set; }
}