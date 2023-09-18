using System;
using System.Collections.Generic;
using Xunit;

public class WordProcessorTests
{
    [Fact]
    public void TestWordCounts()
    {
        WordProcessor wordProcessor = new WordProcessor();
        string input = "It was the best of times, it was the worst of times...";
        Dictionary<string, int> wordCounts = wordProcessor.GetWordCounts(input);

        Assert.Equal(2, wordCounts["it"]);
        Assert.Equal(2, wordCounts["was"]);
        Assert.Equal(2, wordCounts["the"]);
        Assert.Equal(1, wordCounts["best"]);
    }

    [Fact]
    public void TestMostFrequentWords()
    {
        WordProcessor wordProcessor = new WordProcessor();
        string input = "It was the best of times, it was the worst of times...";
        List<string> mostFrequentWords = wordProcessor.GetMostFrequentWords(input, 3);

        Assert.Equal(new List<string> { "it", "was", "the" }, mostFrequentWords);
    }
}
