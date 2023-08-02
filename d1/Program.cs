using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = {
            { 5, 9, 3, 7 },
            { 1, 8, 2, 4 },
            { 6, 0, 11, 10 }
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Упорядочиваем элементы каждой строки по убыванию
        SortRowsDescending(array);

        // Выводим упорядоченный массив
        Console.WriteLine("\nУпорядоченный массив:");
        PrintArray(array);
    }

    static void SortRowsDescending(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        // Проходим по каждой строке массива
        for (int i = 0; i < rows; i++)
        {
            // Создаем временный массив для сортировки
            int[] tempArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                tempArray[j] = arr[i, j];
            }

            // Сортируем временный массив по убыванию
            Array.Sort(tempArray);
            Array.Reverse(tempArray);

            // Копируем отсортированные элементы обратно в исходную строку
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = tempArray[j];
            }
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
