using System;
class recursion
{
    static void Main()
    {
        Console.Write("Input the number of elements to store in the array [maximum 5 digits]: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The Permutations with a combination of " + n + " digits are:");
        Permute(arr, 0, n);
    }
    static void Permute(int[] arr, int start, int n)
    {
        if (start == n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
            Console.Write(" ");
        }
        else
        {
            for (int i = start; i < n; i++)
            {
                Swap(ref arr[start], ref arr[i]);
                Permute(arr, start + 1, n);
                Swap(ref arr[start], ref arr[i]);
            }
        }
    }
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
