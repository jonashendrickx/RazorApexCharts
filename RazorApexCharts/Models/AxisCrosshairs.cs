namespace RazorApexCharts.Models;

/// <summary>
/// Defines styling options to apply to chart crosshairs
/// </summary>
public class AxisCrosshairs
{
    /// <inheritdoc cref="CrosshairsDropShadow" />
    public CrosshairsDropShadow DropShadow { get; set; }

    /// <inheritdoc cref="CrosshairsFill" />
    public CrosshairsFill Fill { get; set; }

    /// <summary>
    /// Opacity of the crosshairs
    /// </summary>
    public double? Opacity { get; set; }

    /// <summary>
    /// Where to place the crosshairs
    /// </summary>
    public GridPosition Position { get; set; }

    /// <summary>
    /// Show crosshairs on axis when user moves the mouse over chart area
    /// </summary>
    public bool? Show { get; set; }

    /// <inheritdoc cref="CrosshairStroke" />
    public CrosshairStroke Stroke { get; set; }

    /// <summary>
    /// Defines the width to apply to the crosshairs
    /// </summary>
    /// <remarks>
    /// Options:
    /// 
    /// <list type="bullet">
    /// <item>Any number</item>
    /// <item>
    ///     <term>tickWidth</term>
    ///     <description>takes the tick intervals on axis and creates a crosshair of that width</description>
    /// </item>
    /// <item>
    ///     <term>barWidth</term>
    ///     <description>takes the barWidth and creates a crosshair of that width – only applicable to vertical bar charts</description>
    /// </item>
    /// </list>
    /// </remarks>
    public object Width { get; set; }
}