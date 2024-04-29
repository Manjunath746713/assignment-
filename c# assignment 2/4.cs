using System;
class length
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int length = CalculateStringLength(input);
        Console.WriteLine($"Length of the string is: {length}");
    }
    static int CalculateStringLength(string str)
    {
        return str.Length;
    }
}