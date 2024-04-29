using System;
class reverse2ing
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string reversedSentence = ReverseWords(sentence);
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversedSentence);
    }
    static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
