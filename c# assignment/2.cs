using System;

class Program
{
    static string GetNthWord(string input, int n)
    {
        // Split the string into words using spaces as separators
        string[] words = input.Split(' ');

        // Check if the specified index is within the range of words
        if (n >= 0 && n < words.Length)
        {
            // Return the nth word
            return words[n];
        }
        else
        {
            // Return an empty string if the index is out of range
            return "";
        }
    }

    static void Main(string[] args)
    {
        // Example usage
        string input = "Deep hash she has fish hash is hash a has dangerous has occupation has because has of has the hash rough has";
        int n = 6;

        string nthWord = GetNthWord(input, n);
        Console.WriteLine($"The {n}th word is: {nthWord}");
    }
}