using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using Xunit;

public class WordProcessorTests
{
    [Fact]
    public void LeftJoin_ReturnsCorrectResult()
    {
        // Arrange
        Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

        Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

        // Act
        List<string[]> result = Program.LeftJoin(synonyms, antonyms);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count);

        Assert.Contains(result, row => row[0] == "diligent" && row[1] == "employed" && row[2] == "idle");
        Assert.Contains(result, row => row[0] == "fond" && row[1] == "enamored" && row[2] == "averse");
        Assert.Contains(result, row => row[0] == "guide" && row[1] == "usher" && row[2] == "follow");
        Assert.Contains(result, row => row[0] == "outfit" && row[1] == "garb" && row[2] == null);
        Assert.Contains(result, row => row[0] == "wrath" && row[1] == "anger" && row[2] == "delight");
    }

    [Fact]
    public void RightJoin_ReturnsCorrectResult()
    {
        // Arrange
        Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

        Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

        // Act
        List<string[]> result = Program.RightJoin(synonyms, antonyms);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count);

        Assert.Contains(result, row => row[0] == "diligent" && row[1] == "employed" && row[2] == "idle");
        Assert.Contains(result, row => row[0] == "fond" && row[1] == "enamored" && row[2] == "averse");
        Assert.Contains(result, row => row[0] == "guide" && row[1] == "usher" && row[2] == "follow");
        Assert.Contains(result, row => row[0] == "flow" && row[1] == null && row[2] == "jam");
        Assert.Contains(result, row => row[0] == "wrath" && row[1] == "anger" && row[2] == "delight");
    }


    [Fact]
    public void RightJoin_EmptyInput_ReturnsEmptyResult()
    {
        // Arrange
        Dictionary<string, string> synonyms = new Dictionary<string, string>();
        Dictionary<string, string> antonyms = new Dictionary<string, string>();

        // Act
        List<string[]> result = Program.RightJoin(synonyms, antonyms);

        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}
