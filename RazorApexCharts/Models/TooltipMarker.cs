namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to tooltip markers
/// </summary>
public class TooltipMarker
{
    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public List<Color> FillColors { get; set; }

    /// <summary>
    /// Whether to show the color coded marker shape in front of Series Name which helps to identify series in multiple datasets.
    /// </summary>
    public bool? Show { get; set; }
}