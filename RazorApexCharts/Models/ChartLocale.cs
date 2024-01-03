namespace RazorApexCharts.Models;

/// <summary>
/// Defines localization options to use with the chart
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/localization">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/chart/locales">JavaScript Reference</see>
/// </remarks>
public class ChartLocale
{
    /// <summary>
    /// Name of the locale you will be defining options for. Can be en, fr, etc
    /// </summary>
    public string Name { get; set; }

    /// <inheritdoc cref="LocaleOptions" />
    public LocaleOptions Options { get; set; }
}