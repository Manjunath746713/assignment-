using System;
class substringssss
{
    static void Main()
    {
        string sentence = "What do you know about me? Out of everything I found nothing for you";
        string substringToFind = "ou";
        Console.WriteLine("All possible substrings of the sentence:");
        FindAllSubstrings(sentence);
        int occurrences = FindSubstringOccurrences(sentence, substringToFind);
        Console.WriteLine($"Occurrences of \"{substringToFind}\": {occurrences}");
    }
    static void FindAllSubstrings(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int len = 1; len <= str.Length - i; len++)
            {
                string substring = str.Substring(i, len);
                Console.WriteLine(substring);
            }
        }
    }
    static int FindSubstringOccurrences(string str, string substring)
    {
        int occurrences = 0;
        for (int i = 0; i <= str.Length - substring.Length; i++)
        {
            bool found = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (str[i + j] != substring[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                occurrences++;
            }
        }
        return occurrences;
    }
}