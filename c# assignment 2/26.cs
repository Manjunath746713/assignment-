using System;
class Large
{
    static void Main()
    {
        string input = "TiGer Is A LaRgE-HeArTeD GentlEmAN witH BounDleSS CouRAgE";
        string output = ConvertCase(input);
        Console.WriteLine("Input character:   " + input);
        Console.WriteLine("Output character: " + output);
    }
    static string ConvertCase(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            int asciiValue = (int)chars[i];
            if (asciiValue >= 65 && asciiValue <= 90)
            {
                
                chars[i] = (char)(asciiValue + 32);
            }
            else if (asciiValue >= 97 && asciiValue <= 122)
            {
                
                chars[i] = (char)(asciiValue - 32);
            }
        }
        return new string(chars);
    }
}