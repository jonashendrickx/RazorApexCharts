namespace RazorApexCharts.Models;

/// <summary>
/// Defines styles to apply during the active state
/// </summary>
public class StatesActive
{
    /// <summary>
    /// Whether to allow selection of multiple datapoints and give them active state or allow one dataPoint selection at a time.
    /// </summary>
    public bool? AllowMultipleDataPointsSelection { get; set; }

    /// <inheritdoc cref="StatesFilter" />
    public StatesFilter Filter { get; set; }
}