using System;
class pyramid
{
    static void Main()
    {
        int rows = 4; // Number of rows in the pyramid
                      // Outer loop for the number of rows
        for (int i = 1; i <= rows; i++)
        {
            // Inner loop for printing spaces before the asterisks
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            // Inner loop for printing asterisks
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
}