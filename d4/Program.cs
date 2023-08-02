using System;

class Program
{
    static void Main()
    {
        // Создаем трехмерный массив размером 2 x 2 x 2
        int[,,] array = new int[2, 2, 2];

        // Заполняем массив неповторяющимися двузначными числами
        int number = 10;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = number++;
                }
            }
        }

        // Выводим массив построчно с добавлением индексов
        Console.WriteLine("Трехмерный массив:");
        PrintArray(array);
    }

    static void PrintArray(int[,,] arr)
    {
        int dim1 = arr.GetLength(0);
        int dim2 = arr.GetLength(1);
        int dim3 = arr.GetLength(2);

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    Console.Write($"[{i}, {j}, {k}] = {arr[i, j, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
