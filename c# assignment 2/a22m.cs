using System;

class cOLD

{

    static void Main()

    {

        string sentence = "It waS a cOLD AND foggy WintEr MorNiNg, I WenT ouT in SearCH of ElusiVe LEoParD";

        char[] chars = sentence.ToCharArray();

        for (int i = 0; i < chars.Length; i++)

        {

            if (chars[i] >= 'a' && chars[i] <= 'z')

            {

                chars[i] = (char)(chars[i] - 32); 

            }

        }

        string uppercaseSentence = new string(chars);

        Console.WriteLine(uppercaseSentence);

    }

}