using System;
class prime
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Prime factors of " + number + " = ");
        FindPrimeFactors(number);
    }
    static void FindPrimeFactors(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.Write(i);
                n /= i;
                if (n != 1)
                    Console.Write("x");
            }
        }
        Console.WriteLine();
    }
}