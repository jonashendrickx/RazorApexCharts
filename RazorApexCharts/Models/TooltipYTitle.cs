namespace RazorApexCharts.Models;

/// <summary>
/// Defines options on how to format the title of a tooltip
/// </summary>
public class TooltipYTitle
{
    /// <summary>
    /// The series name which appears besides values can be formatted using this function. Default behaviour is (seriesName) => returns seriesName
    /// </summary>
    public string Formatter { get; set; }
}