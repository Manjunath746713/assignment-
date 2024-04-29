using System;
class Program
{
    static void Main()
    {
        string originalString = "Hello World!!";
        string reversedString = ReverseString(originalString);
        Console.WriteLine(reversedString);
    }
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}