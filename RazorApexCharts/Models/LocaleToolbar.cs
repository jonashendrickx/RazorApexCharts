namespace RazorApexCharts.Models;

/// <summary>
/// Defines tooltip text required to provide a localization
/// </summary>
public class LocaleToolbar
{
    /// <summary>
    /// Tooltip title text which appears when you hover over download icon
    /// </summary>
    public string Download { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over pan icon
    /// </summary>
    public string Pan { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over reset icon
    /// </summary>
    public string Reset { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over selection icon
    /// </summary>
    public string Selection { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over selection zoom icon
    /// </summary>
    public string SelectionZoom { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over zoom in icon
    /// </summary>
    public string ZoomIn { get; set; }

    /// <summary>
    /// Tooltip title text which appears when you hover over zoom out icon
    /// </summary>
    public string ZoomOut { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string ExportToSVG { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string ExportToPNG { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public string ExportToCSV { get; set; }
}