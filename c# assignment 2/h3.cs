using System;
class indivdualdigit
{
    static void DisplayDigits(int num)
    {
        if (num < 10)
        {
            Console.Write(num + " ");
        }
        else
        {
            DisplayDigits(num / 10);
            Console.Write(num % 10 + " ");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("The digits in the number " + number + " are: ");
        DisplayDigits(number);
        Console.WriteLine();
    }
}