namespace RazorApexCharts.Models;

/// <summary>
/// Class to define styles that are applied on various interaction states with the chart.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/features/state">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/options/states">JavaScript Reference</see>
/// </remarks>
public class States
{
    /// <inheritdoc cref="StatesActive" />
    public StatesActive Active { get; set; }

    /// <inheritdoc cref="StatesHover" />
    public StatesHover Hover { get; set; }

    /// <inheritdoc cref="StatesNormal" />
    public StatesNormal Normal { get; set; }
}