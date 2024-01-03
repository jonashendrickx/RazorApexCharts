namespace RazorApexCharts.Models;

/// <summary>
/// For the default timescale that is generated automatically based on the datetime difference, the below specifiers are used by default.
/// </summary>
public class DatetimeFormatter
{
    /// <summary>
    /// Format specifier for the day of month.
    /// </summary>
    public string Day { get; set; }

    /// <summary>
    /// Format specifier for the hour of day.
    /// </summary>
    public string Hour { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string Minute { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string Second { get; set; }

    /// <summary>
    /// Format specifier for the month.
    /// </summary>
    public string Month { get; set; }

    /// <summary>
    /// Format specifier for the year.
    /// </summary>
    public string Year { get; set; }
}