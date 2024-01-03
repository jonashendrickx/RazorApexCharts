namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to apply to the current state
/// </summary>
public class StatesFilter
{
    /// <summary>
    /// The filter function to apply on hover state.
    /// </summary>
    public StatesFilterType Type { get; set; }

    /// <summary>
    /// A larger value intensifies the filter effect. Accepts values between 0 and 1
    /// </summary>
    public double? Value { get; set; }
}