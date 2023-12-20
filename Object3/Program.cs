﻿// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 9, 12, 16, 20 };

        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(array[index]);

        PrintArrayReverse(array, index - 1);
    }
}