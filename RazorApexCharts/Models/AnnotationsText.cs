namespace RazorApexCharts.Models;

/// <summary>
/// Defines how to style the individual data point annotations and their text
/// </summary>
public class AnnotationsText
{
    /// <summary>
    /// A query selector to which the text element will be appended.
    /// </summary>
    public string AppendTo { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Color BackgroundColor { get; set; }

    /// <summary>
    /// Border Color for the label
    /// </summary>
    public Color BorderColor { get; set; }

    /// <summary>
    /// Border Radius for the label
    /// </summary>
    public double? BorderRadius { get; set; }

    /// <summary>
    /// Border width for the label
    /// </summary>
    public double? BorderWidth { get; set; }

    /// <summary>
    /// Font-family for the annotation label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size for the annotation label
    /// </summary>
    public object FontSize { get; set; }

    /// <summary>
    /// Font-weight for the annotation label
    /// </summary>
    public object FontWeight { get; set; }

    /// <summary>
    /// Undocumented, this property exists in the TypeScript definition
    /// </summary>
    public Color ForeColor { get; set; }

    /// <summary>
    /// Bottom padding for the label
    /// </summary>
    public double? PaddingBottom { get; set; }

    /// <summary>
    /// Left padding for the label
    /// </summary>
    public double? PaddingLeft { get; set; }

    /// <summary>
    /// Right padding for the label
    /// </summary>
    public double? PaddingRight { get; set; }

    /// <summary>
    /// Top padding for the label
    /// </summary>
    public double? PaddingTop { get; set; }

    /// <summary>
    /// The main text to be displayed
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The alignment of text relative to label's drawing position. 
    /// </summary>
    public TextAnchor TextAnchor { get; set; } = TextAnchor.Start;

    /// <summary>
    /// X (left) position for the text relative to the element specified in <see cref="AppendTo"/> property
    /// </summary>
    public double? X { get; set; }

    /// <summary>
    /// Y (top) position for the text relative to the element specified in <see cref="AppendTo"/> property
    /// </summary>
    public double? Y { get; set; }
}