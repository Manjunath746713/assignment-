using System;
class multiplicative
{
    static int Bugger(int n)
    {
        if (n < 10)
        {
            return 0;
        }
        else
        {
            int product = 1;
            while (n != 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return 1 + Bugger(product);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Bugger(39));  // ➞ 3
        Console.WriteLine(Bugger(999)); // ➞ 4
        Console.WriteLine(Bugger(4));   // ➞ 0
    }
}