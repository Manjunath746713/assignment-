using System;
class xshape
{
    static void Main()
    {
        string text = "Hello World!!";
        int length = text.Length;
        int spaces = 0;
        for (int i = 0; i < length; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.Write(text[i]);
            Console.WriteLine(new string(' ', length * 2 - spaces * 2 - 2));
            spaces++;
        }
        spaces--;
        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(new string(' ', spaces));
            Console.Write(text[i]);
            Console.WriteLine(new string(' ', length * 2 - spaces * 2 - 2));
            spaces--;
        }
    }
}