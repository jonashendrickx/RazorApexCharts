namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options for an annotation label
/// </summary>
public class Label
{
    /// <summary>
    /// Border Color of the label
    /// </summary>
    public string BorderColor { get; set; }

    /// <summary>
    /// Border width of the label
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <summary>
    /// Border-radius of the label
    /// </summary>
    public double? BorderRadius { get; set; }

    /// <summary>
    /// Sets the left offset for annotation label
    /// </summary>
    public double? OffsetX { get; set; }

    /// <summary>
    /// Sets the top offset for annotation label
    /// </summary>
    public double? OffsetY { get; set; }

    /// <summary>
    /// The direction to display the label
    /// </summary>
    public Orientation? Orientation { get; set; }

    /// <summary>
    /// Where to place the label
    /// </summary>
    public LabelPosition? Position { get; set; }

    /// <inheritdoc cref="Models.Style" />
    public Style Style { get; set; }

    /// <summary>
    /// Text for tha annotation label
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The alignment of text relative to label's drawing position
    /// </summary>
    public TextAnchor? TextAnchor { get; set; }
}