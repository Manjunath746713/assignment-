﻿using System;

class RightAngleTriangle
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}