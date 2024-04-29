using System;
class  alphanumeric
{
    public static void Main(string[] args)
    {
        Console.Write("Enter alphanumeric: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }
        char currentChar = input[0];
        bool even = true;
        string pattern = currentChar.ToString();
        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsLetterOrDigit(input[i]))
            {
                if (even)
                {
                    pattern += input[i];
                }
                else
                {
                    currentChar = input[i];
                }
                even = !even;
            }
        }
        Console.WriteLine("Pattern: " + pattern);
    }
}