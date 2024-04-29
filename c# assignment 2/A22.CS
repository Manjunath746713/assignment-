using System;
class Program
{
    static void Main()
    {
        string str = "Hello World!!";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(str[i]);
        }
    }
}