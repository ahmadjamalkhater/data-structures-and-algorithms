using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "Once upon a time, there was a brave princess who...";
        WordProcessor wordProcessor = new WordProcessor();
        Dictionary<string, int> wordCounts = wordProcessor.GetWordCounts(input);
        List<string> mostFrequentWords = wordProcessor.GetMostFrequentWords(input, 3);

        Console.WriteLine("Word Counts:");
        foreach (var kvp in wordCounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine($"Top 3 Most Frequent Words: {string.Join(", ", mostFrequentWords)}");


        Console.WriteLine("--------------------");

        string input2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
        Dictionary<string, int> wordCounts2 = wordProcessor.GetWordCounts(input2);
        List<string> mostFrequentWords2 = wordProcessor.GetMostFrequentWords(input2, 3);

        Console.WriteLine("Word Counts:");
        foreach (var kvp in wordCounts2)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine($"Top 3 Most Frequent Words: {string.Join(", ", mostFrequentWords2)}");

        Console.WriteLine("--------------------");

        string input3 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
        Dictionary<string, int> wordCounts3 = wordProcessor.GetWordCounts(input3);
        List<string> mostFrequentWords3 = wordProcessor.GetMostFrequentWords(input3, 3);

        Console.WriteLine("Word Counts:");
        foreach (var kvp in wordCounts3)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine($"Top 3 Most Frequent Words: {string.Join(", ", mostFrequentWords3)}");
    }
}
