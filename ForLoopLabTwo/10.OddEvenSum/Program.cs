﻿namespace _10.OddEvenSum;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += number;  // Четна позиция
            }
            else
            {
                oddSum += number;   // Нечетна позиция
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            int diff = Math.Abs(evenSum - oddSum);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}
