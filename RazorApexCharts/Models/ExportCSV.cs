namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to use when exporting a chart to CSV
/// </summary>
public class ExportCSV
{
    /// <summary>
    /// Name of the csv file. Defaults to auto generated chart ID
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// Delimeter to separate data-items. Defaults to comma.
    /// </summary>
    public string ColumnDelimiter { get; set; }

    /// <summary>
    /// Column Title of X values
    /// </summary>
    public string HeaderCategory { get; set; }

    /// <summary>
    /// Column Title of Y values
    /// </summary>
    public string HeaderValue { get; set; }

    /// <summary>
    /// If timestamps are provided as X values, those timestamps can be formatted to convert them to date strings.
    /// </summary>
    public string DateFormatter { get; set; }
}