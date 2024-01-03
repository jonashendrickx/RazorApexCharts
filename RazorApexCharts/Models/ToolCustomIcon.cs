namespace RazorApexCharts.Models;

/// <summary>
/// Allows to add additional icon buttons in the toolbar. In the below example, index should be used to place at a particular position in the toolbar.
/// </summary>
public class ToolCustomIcon
{
    /// <summary>
    /// Unique Id for the Custom Icon 
    /// </summary>
    [JsonIgnore]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// URL for the icon to display
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// Ordering within the group of icons
    /// </summary>
    public double? Index { get; set; }

    /// <summary>
    /// Tooltip to display for the icon
    /// </summary>
    public string Title { get; set; } = "";

    /// <summary>
    /// A CSS class to apply to the icon
    /// </summary>
    public string Class { get; set; }

    /// <summary>
    /// Javascript function when the icon is clicked
    /// if a OnClick callback is registered this will be overwritten.
    /// </summary>
    public string Click { get; set; }
}