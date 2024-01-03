namespace RazorApexCharts.Models;

/// <summary>
/// Defines the styling options for the annotation label
/// </summary>
public class Style
{
    /// <summary>
    /// Background Color for the annotation label
    /// </summary>
    public Color Background { get; set; }

    /// <summary>
    /// Fore color for the annotation label
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// A custom Css Class to give to the annotation label elements
    /// </summary>
    public string CssClass { get; set; }

    /// <summary>
    /// Font-family for the annotation label
    /// </summary>
    public string FontFamily { get; set; }

    /// <summary>
    /// Font size for the annotation label
    /// </summary>
    public string FontSize { get; set; }

    /// <summary>
    /// Font-weight for the annotation label
    /// </summary>
    public object FontWeight { get; set; }

    /// <inheritdoc cref="Models.Padding"/>
    public Padding Padding { get; set; }
}