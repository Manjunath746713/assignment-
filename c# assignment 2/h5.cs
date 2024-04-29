using System;
class unitss
{
    static void DisplayPlaceValue(int num, int divisor)
    {
        int digit = num / divisor;
        int placeValue = digit * divisor;
        Console.WriteLine("Output: " + placeValue);
    }
    static void Main(string[] args)
    {
        Console.Write("Input Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int divisor = 1;
        int tempNumber = number;
        while (tempNumber >= 10)
        {
            tempNumber /= 10;
            divisor *= 10;
        }
        while (divisor > 0)
        {
            DisplayPlaceValue(number, divisor);
            number %= divisor;
            divisor /= 10;
        }
    }
}