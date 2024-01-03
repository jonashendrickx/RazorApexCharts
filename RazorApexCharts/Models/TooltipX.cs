namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to the X-axis value of a tooltip
/// </summary>
public class TooltipX
{
    /// <summary>
    /// The format of the x-axis value to show on the tooltip. To view how to format datetime Strings, view the <see href="https://apexcharts.com/docs/datetime">Datetime Formatter</see> guide.
    /// </summary>
    public string Format { get; set; }

    /// <summary>
    /// Whether to show the tooltip title (x-axis values) on tooltip or not
    /// </summary>
    public bool? Show { get; set; }

    /// <summary>
    /// A custom formatter function which you can override and display according to your needs (a use case can be a date formatted using complex moment.js functions)
    /// </summary>
    public string Formatter { get; set; }
}