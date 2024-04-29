using System;
class upper
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string input = Console.ReadLine().ToUpper(); 
        string codeWord = GenerateCodeWord(input);
        Console.WriteLine("Code word:");
        Console.WriteLine(codeWord);
    }
    static string GenerateCodeWord(string word)
    {
        char[] chars = word.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'A' && chars[i] <= 'W')
            {
                chars[i] = (char)(chars[i] + 3);
            }
            else
            {
                chars[i] = (char)(chars[i] - 23); 
            }
        }
        return new string(chars);
    }
}