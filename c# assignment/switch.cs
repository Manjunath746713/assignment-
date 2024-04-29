using System;

class IncrementDigits
{
    static int IncrementNumber(int num)
    {
        int result = 0;
        int multiplier = 1;

        while (num > 0)
        {
            int digit = (num % 10 + 1) % 10;
            result += digit * multiplier;
            multiplier *= 10;
            num /= 10;
        }

        return result;
    }

    static void Main()
    {
        int inputNumber = 12391;
        int newNumber = IncrementNumber(inputNumber);
        Console.WriteLine("New number: " + newNumber);
    }
}