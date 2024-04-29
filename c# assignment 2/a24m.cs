
using System;
class diamond

{

    static void Main()

    {

        int n = 5;

        int space = n - 1;

        int stars = 1;

      
        for (int i = 1; i <= n; i++)

        {

            for (int j = 1; j <= space; j++)

                Console.Write(" ");

            for (int j = 1; j <= stars; j++)

                Console.Write("*");

            Console.WriteLine();

            space--;

            stars += 2;

        }

        

        space = 1;

        stars = 2 * n - 3;

        for (int i = 1; i <= n - 1; i++)

        {

            for (int j = 1; j <= space; j++)

                Console.Write(" ");

            for (int j = 1; j <= stars; j++)

                Console.Write("*");

            Console.WriteLine();

            space++;

            stars -= 2;

        }

    }

}