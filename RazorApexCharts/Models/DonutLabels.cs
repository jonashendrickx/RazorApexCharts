namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style text labels for each donut slice
/// </summary>
public class DonutLabels
{
    /// <inheritdoc cref="DonutLabelName" />
    public DonutLabelName Name { get; set; }

    /// <summary>
    /// Whether to display inner labels or not.
    /// </summary>
    public bool Show { get; set; } = true;

    /// <inheritdoc cref="DonutLabelTotal" />
    public DonutLabelTotal Total { get; set; }

    /// <inheritdoc cref="DonutLabelValue" />
    public DonutLabelValue Value { get; set; }
}