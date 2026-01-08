using System;
using System.Text;

namespace ConsoleApp;

public class StringProcessor
{
    public static string CompressString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        // lowercase
        string lowerInput = input.ToLower();

        StringBuilder result = new StringBuilder();

        result.Append(lowerInput[0]);

        for (int i = 1; i < lowerInput.Length; i++)
        {
            // Compare current character with the previous one
            // Append if it's different
            if (lowerInput[i] != lowerInput[i - 1])
            {
                result.Append(lowerInput[i]);
            }
        }

        return result.ToString();
    }

    public static void Main(string[] args)
    {
        // Define test cases
        string[] testCases = {
            "AAaaBBccC",
            "aA11BB22bb",
            "Hellooo000WORLD",
            "111222333",
            "NoDuplicates"
        };

        Console.WriteLine("============================");

        foreach (var test in testCases)
        {
            string output = CompressString(test);
            Console.WriteLine($"Input: {test,-15} | Output: {output}");
        }
    }
}
