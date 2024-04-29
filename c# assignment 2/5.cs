using System;
class nthword
{
    static void Main()
    {
        string inputString = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea#";
        int n = 5; 
        string nthWord = GetNthWord(inputString, n);
        Console.WriteLine($"The {n}-th word is: {nthWord}");
    }
    static string GetNthWord(string str, int n)
    {
        string[] words = str.Split('#');
        if (n <= 0 || n > words.Length)
        {
            throw new ArgumentException("Invalid value of n.");
        }
        return words[n - 1];
    }
}