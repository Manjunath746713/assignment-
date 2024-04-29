using System;
class pyramidnoincreases
{
    static void Main()
    {
        int rows = 4; 
        int currentNumber = 1;
                               
        for (int i = 1; i <= rows; i++)
        {
           
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write("  "); 
            }
           
            for (int k = 1; k <= i; k++)
            {
                Console.Write(currentNumber.ToString().PadLeft(2) + " ");
                currentNumber++; 
            }
            Console.WriteLine(); 
        }
    }
}