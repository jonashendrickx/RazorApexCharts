namespace RazorApexCharts.Models;

/// <summary>
/// You can configure different options for different screen sizes and ApexCharts will override the configuration based on breakpoints defined.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/responsive">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/responsive">JavaScript Reference</see>
/// </remarks>
public class Responsive
{
    /// <summary>
    /// The breakpoint is the max screen width at which the original config object will be overrided by the responsive config object
    /// </summary>
    public double? Breakpoint { get; set; }

    /// <summary>
    /// The new configuration object that you would like to override on the existing default configuration object. All the options which you set normally can be set here. <see href="https://codepen.io/apexcharts/pen/ajpqJp">Example</see>
    /// </summary>
    public object Options { get; set; }
}