using System;
class substrings
{
    static void Main()
    {
        Console.Write("Input the original string: ");
        string originalString = Console.ReadLine();
        Console.Write("Input the string to be searched for: ");
        string searchString = Console.ReadLine();
        Console.Write("Input the string to be inserted: ");
        string insertString = Console.ReadLine();
        string modifiedString = InsertAfterFirstOccurrence(originalString, searchString, insertString);
        Console.WriteLine("The modified string is: \"" + modifiedString + "\"");
    }
    static string InsertAfterFirstOccurrence(string original, string search, string insert)
    {
        int index = original.IndexOf(search);
        if (index == -1)
        {
            return original; 
        }
       
        return original.Substring(0, index + search.Length) + insert + original.Substring(index + search.Length);
    }
}