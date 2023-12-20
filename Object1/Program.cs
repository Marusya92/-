//  Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int M = 10;
        int N = 20;

        PrintNaturalNumbersInRange(M, N);
    }

    static void PrintNaturalNumbersInRange(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        Console.WriteLine(start);

        PrintNaturalNumbersInRange(start + 1, end);
    }
}