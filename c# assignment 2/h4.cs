using System;
class countthenumber
{
    static int CountDigits(int num)
    {
        if (num < 10)
        {
            return 1;
        }
        else
        {
            return 1 + CountDigits(num / 10);
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine("The number " + number + " contains the number of digits: " + digitCount);
    }
}