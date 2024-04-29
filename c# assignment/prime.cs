using System;

class PrimeNumbersInRange
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static void FindPrimesInRange(int start, int end)
    {
        Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the starting number of range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the ending number of range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        FindPrimesInRange(start, end);
    }
}