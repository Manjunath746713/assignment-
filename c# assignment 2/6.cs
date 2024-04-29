using System;
class five
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        string input = Console.ReadLine();
        if (input.Length != 5 || !IsNumeric(input))
        {
            Console.WriteLine("Invalid input. Please enter a five-digit number.");
            return;
        }
        string newNumber = AddOneToEachDigit(input);
        Console.WriteLine($"New number after adding '1' to each digit: {newNumber}");
    }
    static bool IsNumeric(string value)
    {
        return int.TryParse(value, out _);
    }
    static string AddOneToEachDigit(string number)
    {
        char[] digits = number.ToCharArray();
        for (int i = 0; i < digits.Length; i++)
        {
            int digit = int.Parse(digits[i].ToString());
            digit = (digit + 1) % 10; 
            digits[i] = char.Parse(digit.ToString());
        }
        return new string(digits);
    }
}