using System;
class palindrommee

{
    static string LongestPalindromicSubstring(string str)
    {
        int n = str.Length;
        bool[,] table = new bool[n, n];
        
        int maxLength = 1;
        for (int i = 0; i < n; ++i)
        {
            table[i, i] = true;
        }
        
        int start = 0;
        for (int i = 0; i < n - 1; ++i)
        {
            if (str[i] == str[i + 1])
            {
                table[i, i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }
        // Check for substrings of length greater than 2
        for (int k = 3; k <= n; ++k)
        {
            for (int i = 0; i < n - k + 1; ++i)
            {
                int j = i + k - 1;
                if (table[i + 1, j - 1] && str[i] == str[j])
                {
                    table[i, j] = true;
                    if (k > maxLength)
                    {
                        start = i;
                        maxLength = k;
                    }
                }
            }
        }
        return str.Substring(start, maxLength);
    }
    static void Main(string[] args)
    {
        string input = "bananas";
        string longestPalindrome = LongestPalindromicSubstring(input);
        Console.WriteLine("The longest palindromic substring of \"" + input + "\" is \"" + longestPalindrome + "\".");
    }
}
