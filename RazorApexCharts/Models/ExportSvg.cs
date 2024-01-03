namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to use when exporting a chart to SVG
/// </summary>
public class ExportSvg
{
    /// <summary>
    /// Name of the SVG file. Defaults to auto generated chart ID
    /// </summary>
    public string Filename { get; set; }
}