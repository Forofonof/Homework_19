using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
        int sum = 0;
        int multiply = 1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[1, i];
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            multiply *= array[i, 0];
        }

        Console.WriteLine($"Сумма второй строки: {sum}\nПроизведение первого столбца: {multiply}");
    }
}