using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


    //public Dictionary<string, int> GetWordCounts(string input)
    //{
    //    // Split the input string into words
    //    string[] words = Regex.Split(input, @"\W+");

    //    // Create a dictionary to store word frequencies
    //    Dictionary<string, int> wordCount = new Dictionary<string, int>();

    //    foreach (string word in words)
    //    {
    //        // Remove punctuation and convert to lowercase for case-insensitive comparison
    //        string cleanedWord = word.Trim(new char[] { '.', ',', '!', '?', '-', ':', ';' }).ToLower();

    //        // Update the word count
    //        if (wordCount.ContainsKey(cleanedWord))
    //        {
    //            wordCount[cleanedWord]++;
    //        }
    //        else
    //        {
    //            wordCount[cleanedWord] = 1;
    //        }
    //    }

    //    return wordCount;
    //}

    //public List<string> GetMostFrequentWords(string input, int count)
    //{
    //    Dictionary<string, int> wordCount = GetWordCounts(input);

    //    // Sort the dictionary by value in descending order
    //    var sortedWordCount = wordCount.OrderByDescending(kv => kv.Value);

    //    // Take the top 'count' words
    //    var mostFrequentWords = sortedWordCount.Take(count).Select(kv => kv.Key).ToList();

    //    return mostFrequentWords;
    //}
    public class RepeatedWord
    {
        public static string FindFirstRepeatedWord(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            string[] words = Regex.Split(input.ToLower(), @"\W+");

            HashSet<string> reapeted = new HashSet<string>();

            foreach (string word in words)
            {
                if (!reapeted.Add(word))
                {
                    return word;
                }
            }

            return null;
        }
    }

