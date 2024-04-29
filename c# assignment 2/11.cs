using System;
class serialnotri
{
    static void Main()
    {
        int rows = 4; 
        int currentNumber = 1; 
                               
        for (int i = 1; i <= rows; i++)
        {
           
            for (int j = 1; j <= i; j++)
            {
                Console.Write(currentNumber + " ");
                currentNumber++; 
            }
            Console.WriteLine(); 
        }
    }
}