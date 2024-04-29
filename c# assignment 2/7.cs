using System;
class wordcount
{
    static void Main()
    {
        string sentence = "A tiger is a large-hearted gentleman with boundless courage";
        int wordCount = CountWords(sentence);
        Console.WriteLine($"Number of words: {wordCount}");
    }
    static int CountWords(string sentence)
    {
        int wordCount = 0;
        bool inWord = false;
        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    inWord = true;
                    wordCount++;
                }
            }
            else
            {
                inWord = false;
            }
        }
        return wordCount;
    }
}
