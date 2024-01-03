namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to use when exporting charts
/// </summary>
public class ExportOptions
{
    /// <inheritdoc cref="ExportCSV" />
    public ExportCSV Csv { get; set; }

    /// <inheritdoc cref="ExportSvg" />
    public ExportSvg Svg { get; set; }

    /// <inheritdoc cref="ExportPng" />
    public ExportPng Png { get; set; }
}