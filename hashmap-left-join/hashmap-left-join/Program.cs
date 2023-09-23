using System;
using System.Collections.Generic;

public class Program
{
    public static List<string[]> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
    {
        List<string[]> result = new List<string[]>();

        foreach (var key in synonyms.Keys)
        {
            string synonymValue = synonyms[key];
            string antonymValue;

            if (antonyms.TryGetValue(key, out antonymValue))
            {
                result.Add(new string[] { key, synonymValue, antonymValue });
            }
            else
            {
                result.Add(new string[] { key, synonymValue, null });
            }
        }

        return result;
    }

    public static List<string[]> RightJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
    {
        List<string[]> result = new List<string[]>();

        foreach (var key in antonyms.Keys)
        {
            string antonymValue = antonyms[key];
            string synonymValue;

            if (synonyms.TryGetValue(key, out synonymValue))
            {
                result.Add(new string[] { key, synonymValue, antonymValue });
            }
            else
            {
                result.Add(new string[] { key, null, antonymValue });
            }
        }

        return result;
    }

    public static void Main()
    {
        Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "Python", "interpreted" },
            { "Java", "compiled" },
            { "JavaScript", "interpreted" },
            { "C#", "compiled" },
            { "Ruby", "interpreted" }
        };

        Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "Python", "static" },
            { "Java", "dynamic" },
            { "JavaScript", "static" },
            { "C++", "static" },
            { "Ruby", "static" }
        };

        // LEFT JOIN
        List<string[]> leftJoinResult = LeftJoin(synonyms, antonyms);
        foreach (var row in leftJoinResult)
        {
            Console.WriteLine($"[{string.Join(", ", row)}]");
        }

        // RIGHT JOIN
        List<string[]> rightJoinResult = RightJoin(synonyms, antonyms);
        foreach (var row in rightJoinResult)
        {
            Console.WriteLine($"[{string.Join(", ", row)}]");
        }
    }
}
