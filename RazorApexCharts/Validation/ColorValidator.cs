using System.Text.RegularExpressions;

namespace RazorApexCharts.Validation;

public static class ColorValidator
{
    private static readonly Regex HexRegex = new(@"^#(?:[0-9a-fA-F]{3,4}){1,2}$", RegexOptions.Compiled);
    
    public static bool IsValid(string hex)
    {
        return HexRegex.IsMatch(hex);
    }
}