namespace RazorApexCharts.Models;

public class ApexChartOptions<TItem>
    {
        /// <summary>
        /// Logs function calls and options to the browser console when true
        /// </summary>
        public bool Debug { get; set; }

        /// <inheritdoc cref="Models.Annotations" />
        public Annotations Annotations { get; set; }

        /// <inheritdoc cref="Models.Chart" />
        public Chart Chart { get; set; } = new();

        /// <summary>
        /// Colors for the chart's series. When all colors of the array are used, it starts from the beginning. Predefined colors are available in <see href="https://apexcharts.com/docs/options/theme">theme palettes</see>
        /// </summary>
        /// <remarks>
        /// You should only provide either hex or rgb/rgba format. Color names are not accepted at the moment.
        /// 
        /// Links:
        /// 
        /// <see href="https://apexcharts.com/docs/colors">JavaScript Documentation</see>,
        /// <see href="https://apexcharts.com/docs/options/colors">JavaScript Reference</see>
        /// </remarks>
        public List<Color> Colors { get; set; }

        /// <inheritdoc cref="Models.DataLabels" />
        public DataLabels DataLabels { get; set; }

        /// <inheritdoc cref="Models.Fill" />
        public Fill Fill { get; set; }

        /// <inheritdoc cref="Models.ForecastDataPoints" />
        public ForecastDataPoints ForecastDataPoints { get; set; }

        /// <inheritdoc cref="Models.Grid" />
        public Grid Grid { get; set; }

        /// <summary>
        /// In Axis Charts (line / column), labels can be set instead of setting xaxis categories option. While, in pie/donut charts, each label corresponds to value in series array.
        /// </summary>
        /// <remarks>
        /// Links:
        /// 
        /// <see href="https://apexcharts.com/docs/options/labels">JavaScript Reference</see>
        /// </remarks>
        public List<string> Labels { get; set; }

        /// <inheritdoc cref="Models.Legend" />
        public Legend Legend { get; set; }

        /// <inheritdoc cref="Models.Markers" />
        public Markers Markers { get; set; }

        /// <inheritdoc cref="Models.NoData" />
        public NoData NoData { get; set; }

        /// <inheritdoc cref="Models.PlotOptions" />
        public PlotOptions PlotOptions { get; set; }

        /// <inheritdoc cref="Models.Responsive" />
        public List<Responsive> Responsive { get; set; }

        /// <inheritdoc cref="Series{TItem}" />
        public List<Series<TItem>> Series { get; set; }

        /// <inheritdoc cref="Models.States" />
        public States States { get; set; }

        /// <inheritdoc cref="Models.Stroke" />
        public Stroke Stroke { get; set; }

        /// <inheritdoc cref="Models.Subtitle" />
        public Subtitle Subtitle { get; set; }

        /// <inheritdoc cref="Models.Theme" />
        public Theme Theme { get; set; }

        /// <inheritdoc cref="Models.Title" />
        public Title Title { get; set; }

        /// <inheritdoc cref="Models.Tooltip" />
        public Tooltip Tooltip { get; set; }

        /// <inheritdoc cref="XAxis" />
        public XAxis Xaxis { get; set; }

        /// <inheritdoc cref="YAxis" />
        public List<YAxis> Yaxis { get; set; }
    }