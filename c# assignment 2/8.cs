﻿using System;
class Pattern
{
    static void Main()
    {
        int rows = 4; 
                      
        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}