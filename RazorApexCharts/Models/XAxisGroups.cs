namespace RazorApexCharts.Models;

/// <summary>
/// Defines options to apply to groups within the X-axis
/// </summary>
public class XAxisGroups
{
    /// <inheritdoc cref="XAxisGroup" />
    public List<XAxisGroup> Groups { get; set; }

    /// <inheritdoc cref="XAxisGroupStyle" />
    public XAxisGroupStyle Style { get; set; }
}