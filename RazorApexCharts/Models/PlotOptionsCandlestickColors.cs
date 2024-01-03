namespace RazorApexCharts.Models;

/// <summary>
/// The colors to use for data points on the candlestick chart
/// </summary>
public class PlotOptionsCandlestickColors
{
    /// <summary>
    /// Color for the downward candle when the value/price closed below where it opened. Usually, a red color is used for this downward candle.
    /// </summary>
    public string Downward { get; set; }

    /// <summary>
    /// Color for the upward candle when the value/price closed above where it opened. Usually, a green color is used for this upward candle.
    /// </summary>
    public string Upward { get; set; }
}