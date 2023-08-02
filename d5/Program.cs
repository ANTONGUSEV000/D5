using System;

class Program
{
    static void Main()
    {
        int size = 4;
        int[,] array = new int[size, size];

        FillSpiralArray(array);

        // Выводим массив на экран
        Console.WriteLine("Спиральный массив:");
        PrintArray(array);
    }

    static void FillSpiralArray(int[,] arr)
    {
        int size = arr.GetLength(0);
        int value = 1;
        int rowStart = 0;
        int rowEnd = size - 1;
        int colStart = 0;
        int colEnd = size - 1;

        while (value <= size * size)
        {
            // Заполнение верхней горизонтальной строки
            for (int col = colStart; col <= colEnd; col++)
            {
                arr[rowStart, col] = value++;
            }
            rowStart++;

            // Заполнение правого столбца
            for (int row = rowStart; row <= rowEnd; row++)
            {
                arr[row, colEnd] = value++;
            }
            colEnd--;

            // Заполнение нижней горизонтальной строки
            for (int col = colEnd; col >= colStart; col--)
            {
                arr[rowEnd, col] = value++;
            }
            rowEnd--;

            // Заполнение левого столбца
            for (int row = rowEnd; row >= rowStart; row--)
            {
                arr[row, colStart] = value++;
            }
            colStart++;
        }
    }

    static void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

