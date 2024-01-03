using RazorApexCharts.Models.Enums;

namespace RazorApexCharts.Models;

/// <summary>
/// If you don't want to define your own colorPalette, choose a pre-defined palette in theme.palette property. ApexCharts has 10+ built in color palettes to choose from. To apply palette globally to all charts, set Apex.theme.palette property.
/// </summary>
/// <remarks>
/// Links:
/// 
/// <see href="https://apexcharts.github.io/Blazor-ApexCharts/chart-themes">Blazor Example</see>,
/// <see href="https://apexcharts.com/docs/themes">JavaScript Documentation</see>,
/// <see href="https://apexcharts.com/docs/options/theme">JavaScript Reference</see>
/// </remarks>
public class Theme
{
    /// <summary>
    /// Changing the theme.mode will also update the text and background colors of the chart.
    /// </summary>
    public Mode? Mode { get; set; }

    /// <inheritdoc cref="ThemeMonochrome" />
    public ThemeMonochrome Monochrome { get; set; }

    /// <summary>
    /// Available palettes – palette1 to palette10
    /// </summary>
    public PaletteType? Palette { get; set; }
}