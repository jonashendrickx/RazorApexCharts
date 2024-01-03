namespace RazorApexCharts.Models;

/// <summary>
/// Defines required properties to provide a localization
/// </summary>
public class LocaleOptions
{
    /// <summary>
    /// Full names of days in your language
    /// </summary>
    public List<string> Days { get; set; }

    /// <summary>
    /// Full month names in your preferred language
    /// </summary>
    public List<string> Months { get; set; }

    /// <summary>
    /// Abbreviated day names
    /// </summary>
    public List<string> ShortDays { get; set; }

    /// <summary>
    /// Abbreviations of months
    /// </summary>
    public List<string> ShortMonths { get; set; }

    /// <inheritdoc cref="LocaleToolbar" />
    public LocaleToolbar Toolbar { get; set; }
}