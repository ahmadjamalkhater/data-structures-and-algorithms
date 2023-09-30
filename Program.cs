using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static string FindMostCommonWord(string book)
    {
        // Convert the book to lowercase and split it into words
        string[] words = Regex.Split(book.ToLower(), @"\W+");

        // Create a dictionary to store word counts
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Initialize temporary variables to store the most common word and its count
        string mostCommonWord = "";
        int mostCommonCount = 0;

        foreach (string word in words)
        {
            if (word != "")
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }

                // Update most common word if a new most common word is found
                if (wordCount[word] > mostCommonCount || (wordCount[word] == mostCommonCount && string.CompareOrdinal(word, mostCommonWord) < 0))
                {
                    mostCommonWord = word;
                    mostCommonCount = wordCount[word];
                }
            }
        }

        return mostCommonWord;
    }

    static void Main()
    {
        string bookText = "This is a sample book. This book contains multiple words. This is a simple example.";
        string mostCommonWord = FindMostCommonWord(bookText);
        Console.WriteLine("The most common word in the book is: " + mostCommonWord);
    }
}
