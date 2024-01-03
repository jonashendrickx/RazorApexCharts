namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options to apply to the data labels
/// </summary>
public class DataLabelsStyle
{
    /// <summary>
    /// Fore colors for the dataLabels. Accepts an array of Color Colors (['#333', '#999']) or an array of functions ([function(opts) { return '#333' }]) (Each index in the array corresponds to the series).
    /// </summary>
    public List<Color> Colors { get; set; }

    /// <summary>
    /// Font family for the label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size for the label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font weight for the label. Can be String ('bold') or number (400/500)
    /// </summary>
    public object FontWeight { get; set; }
}