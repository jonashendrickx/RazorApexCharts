namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to use when exporting a chart to PNG
/// </summary>
public class ExportPng
{
    /// <summary>
    /// Name of the PNG file. Defaults to auto generated chart ID
    /// </summary>
    public string Filename { get; set; }
}