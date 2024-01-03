namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options to apply to the background for data labels
/// </summary>
public class DataLabelsBackground
{
    /// <summary>
    /// Border color of the background rect.
    /// </summary>
    public string BorderColor { get; set; }

    /// <summary>
    /// Border radius of the background rect.
    /// </summary>
    public double? BorderRadius { get; set; }

    /// <summary>
    /// Border width of the background rect.
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <inheritdoc cref="Models.DropShadow" />
    public DropShadow DropShadow { get; set; }

    /// <summary>
    /// Should draw a background rectangle around the label
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Color of the label when background is enabled. This will override the <see cref="DataLabelsStyle.Colors"/>.
    /// </summary>
    public Color ForeColor { get; set; }

    /// <summary>
    /// Opacity of the background color.
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// The amount of padding to apply to the data label background
    /// </summary>
    public double? Padding { get; set; }
}