using System;

class Program
{
    static void Main()
    {
        // Создаем прямоугольный двумерный массив
        int[,] array = {
            { 5, 9, 3, 7 },
            { 1, 8, 2, 4 },
            { 6, 0, 11, 10 }
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим индекс строки с наименьшей суммой элементов
        int minSumRowIndex = FindRowWithMinSum(array);

        // Выводим результат
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}");
    }

    static int FindRowWithMinSum(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int minSum = int.MaxValue;
        int minSumIndex = -1;

        // Проходим по каждой строке массива
        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;

            // Считаем сумму элементов текущей строки
            for (int j = 0; j < cols; j++)
            {
                currentSum += arr[i, j];
            }

            // Если текущая сумма меньше минимальной, обновляем минимальную сумму и индекс строки
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumIndex = i;
            }
        }

        return minSumIndex;
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
