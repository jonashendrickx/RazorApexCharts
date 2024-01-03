namespace RazorApexCharts.Models.DataPoints;

/// <summary>
/// Used to create data points for chart types with a singular Y-value
/// </summary>
/// <typeparam name="TItem">The data type to be used in the chart to create data points.</typeparam>
public class DataPoint<TItem> : IDataPoint<TItem>
{
    /// <inheritdoc cref="IDataPoint{TItem}.FillColor"/>
    public Color FillColor { get; set; }

    /// <inheritdoc cref="IDataPoint{TItem}.X"/>
    public object X { get; set; }

    /// <summary>
    /// A collection of goal markers to display with the data point
    /// </summary>
    public List<DataPointGoal> Goals { get; set; }

    /// <summary>
    /// The Y-value for the data point to create on the chart
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public decimal? Y { get; set; }

    /// <inheritdoc cref="IDataPoint{TItem}.Items"/>
    [JsonIgnore]
    public IEnumerable<TItem> Items { get; set; }

    /// <inheritdoc cref="IDataPoint{TItem}.Extra"/>
    public object Extra { get; set; }

    /// <summary>
    /// Used to store the individual data points that were grouped to create the current data point
    /// </summary>
    /// <remarks>
    /// Will be available when <see cref="ApexChart{TItem}.GroupPoints"/> is used
    /// </remarks>
    [JsonIgnore]
    public List<DataPoint<TItem>> GroupedPoints { get; internal set; }
}