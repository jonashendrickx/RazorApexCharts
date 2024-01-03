using System.Runtime.Serialization;

namespace RazorApexCharts.Models;

/// <summary>
/// A list of stacking options for stacked charts
/// </summary>
public enum StackType
{
    Normal,
    [EnumMember(Value = "100%")]
    Percent100
};