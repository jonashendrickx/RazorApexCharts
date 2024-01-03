using System.Text.Json;

namespace RazorApexCharts.Tests.Serialization;

public class ColorConverterTests
{
    [Fact]
    public void Write_ConvertsColorToHexFormat()
    {
        // Arrange
        var color = new Color(255, 0, 0, 127);

        // Act
        var actual = JsonSerializer.Serialize(color);

        // Assert
        Assert.Equal("\"#FF00007F\"", actual);
    }

    [Fact]
    public void Write_ConvertsColorWithoutAlphaToHexFormat()
    {
        // Arrange
        var color = new Color(255, 0, 0);

        // Act
        var actual = JsonSerializer.Serialize(color);

        // Assert
        Assert.Equal("\"#FF0000\"", actual);
    }
}
