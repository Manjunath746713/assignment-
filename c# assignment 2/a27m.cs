
using System.Collections.Generic;

class repeatingastring

{

    static void Main()

    {

        System.Console.WriteLine(Unrepeated("teshahset")); // Output: tesha

        System.Console.WriteLine(Unrepeated("hello"));    // Output: helo

        System.Console.WriteLine(Unrepeated("call 911")); // Output: cal 91

    }

    static string Unrepeated(string word)

    {

        HashSet<char> seen = new HashSet<char>();

        List<char> result = new List<char>();

        foreach (char c in word)

        {

            if (!seen.Contains(c))

            {

                result.Add(c);

                seen.Add(c);

            }

        }

        return new string(result.ToArray());

    }

}