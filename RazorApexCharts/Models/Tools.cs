namespace RazorApexCharts.Models;

/// <summary>
/// Defines the options to display the toolbar with
/// </summary>
public class Tools
{
    /// <inheritdoc cref="ToolCustomIcon" />
    public List<ToolCustomIcon> CustomIcons { get; set; }

    /// <summary>
    /// Show the download menu / hamburger icon in the toolbar. 
    /// If you want to display a custom icon, you can provide HTML string in this property.
    /// 
    /// <code>
    /// download: true 
    /// download: '&lt;img src="/static/icons/download.png" class="ico-download" width="20"&gt;'
    /// </code>
    /// 
    /// ApexCharts has built-in support to allow exporting the chart to popular image formats like PNG or SVG and also allows exporting the chart data to a CSV file.
    /// By default, all XY charts have the toolbar enabled in them which has a hamburger icon at the top right corner. Clicking the hamburger icon opens a menu which has following options to download.
    /// </summary>
    public object Download { get; set; } = true;

    /// <summary>
    /// Show the panning icon in the toolbar. 
    /// If you want to display a custom icon for Pan, you can provide HTML string in this property.
    /// </summary>
    public object Pan { get; set; } = true;

    /// <summary>
    /// Reset the chart data to it's initial state after zommin/zoomout/panning. 
    /// If you want to display a custom icon for reset, you can provide HTML string in this property.
    /// </summary>
    public object Reset { get; set; } = true;

    /// <summary>
    /// Show the rectangle selection icon in the toolbar. 
    /// If you want to display a custom icon for selection, you can provide HTML string in this property.
    /// </summary>
    /// <remarks>
    /// Make sure to also enable <see cref="Chart.Selection"/> when showing the selection tool.
    /// </remarks>
    public object Selection { get; set; } = true;

    /// <summary>
    /// Show the zoom icon which is used for zooming by dragging selection on the chart area. 
    /// If you want to display a custom icon for zoom, you can provide HTML string in this property.
    /// </summary>
    public object Zoom { get; set; } = true;

    /// <summary>
    /// Show the zoom-in icon which zooms in 50% from the visible chart area. 
    /// If you want to display a custom icon for zoom-in, you can provide HTML string in this property.
    /// </summary>
    public object Zoomin { get; set; } = true;

    /// <summary>
    /// Show the zoom-out icon which zooms out 50% from the visible chart area. 
    /// If you want to display a custom icon for zoom-out, you can provide HTML string in this property.
    /// </summary>
    public object Zoomout { get; set; } = true;
}