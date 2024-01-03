namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling to apply to legend item labels
/// </summary>
public class LegendLabels
{
    /// <inheritdoc cref="ApexCharts.Color"/>
    /// <summary>
    /// Custom text colors for legend labels.
    /// </summary>
    public Color Colors { get; set; }

    /// <summary>
    /// Whether to use primary <see href="https://apexcharts.com/docs/colors">colors</see> or not.
    /// </summary>
    public bool? UseSeriesColors { get; set; }
}