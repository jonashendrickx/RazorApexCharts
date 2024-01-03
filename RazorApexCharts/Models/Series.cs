using RazorApexCharts.Models.DataPoints;
using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary> 
/// The series is a set of data. You may have single or multiple data series. The series object can be of the following format: Single values, Paired values, Timeline Series, or Data for Pie/Donuts/RadialBars
/// </summary>
/// <typeparam name="TItem">The data type to be used in the chart to create data points.</typeparam>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.com/docs/series">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/series">JavaScript Reference</see>
/// </remarks>
public class Series<TItem>
{
    /// <summary>
    /// The group of individual data points to display on the chart.
    /// </summary>
    public IEnumerable<IDataPoint<TItem>> Data { get; set; }

    /// <inheritdoc cref="IApexSeries{TItem}.Name"/>
    public string Name { get; set; }

    /// <inheritdoc cref="System.Text.RegularExpressions.Group"/>
    public string Group { get; set; }
      
    /// <summary>
    /// The internal type of this series
    /// </summary>
    public MixedType? Type { get; set; }
}