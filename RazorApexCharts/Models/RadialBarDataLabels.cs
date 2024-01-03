namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style labels for the radial bar chart
/// </summary>
public class RadialBarDataLabels
{
    /// <inheritdoc cref="RadialBarDataLabelsName" />
    public RadialBarDataLabelsName Name { get; set; }

    /// <summary>
    /// Whether to display labels inside radialBars or not
    /// </summary>
    public bool? Show { get; set; }

    /// <inheritdoc cref="RadialBarDataLabelsTotal" />
    public RadialBarDataLabelsTotal Total { get; set; }

    /// <inheritdoc cref="RadialBarDataLabelsValue" />
    public RadialBarDataLabelsValue Value { get; set; }
}