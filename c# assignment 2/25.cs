using System;
class middleofeven
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string middle = GetMiddleCharacters(input);
        Console.WriteLine("Middle character(s): " + middle);
    }
    static string GetMiddleCharacters(string str)
    {
        int length = str.Length;
        int middleIndex = length / 2;
        if (length % 2 == 0)
        {
            // If the length is even, return two middle characters
            return str.Substring(middleIndex - 1, 2);
        }
        else
        {
            // If the length is odd, return the middle character
            return str.Substring(middleIndex, 1);
        }
    }
}