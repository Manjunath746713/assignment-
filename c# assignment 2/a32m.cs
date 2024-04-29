
using System;

class reveresetheorder

{

    static void Main()

    {

        Console.WriteLine("Enter a string:");

        string input = Console.ReadLine();

        string reversedCaseString = ReverseCase(input);

        Console.WriteLine("Reversed case string:");

        Console.WriteLine(reversedCaseString);

    }

    static string ReverseCase(string input)

    {

        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)

        {

            if (char.IsUpper(chars[i]))

            {

                chars[i] = char.ToLower(chars[i]);

            }

            else if (char.IsLower(chars[i]))

            {

                chars[i] = char.ToUpper(chars[i]);

            }

        }

        return new string(chars);

    }

}