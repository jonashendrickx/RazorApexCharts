namespace RazorApexCharts.Models;

/// <summary>
/// Defines an individual group within the X-axis
/// </summary>
public class XAxisGroup
{
    /// <summary>
    /// The name to apply to the group
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The number of columns in the group
    /// </summary>
    public int Cols { get; set; }
}