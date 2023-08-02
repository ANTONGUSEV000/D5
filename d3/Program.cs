using System;

class Program
{
    static void Main()
    {
        // Задаем две матрицы
        int[,] matrix1 = {
            { 1, 2 },
            { 3, 4 }
        };

        int[,] matrix2 = {
            { 5, 6 },
            { 7, 8 }
        };

        // Выводим исходные матрицы
        Console.WriteLine("Исходная матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nИсходная матрица 2:");
        PrintMatrix(matrix2);

        // Вычисляем произведение матриц
        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        // Выводим результат
        Console.WriteLine("\nРезультирующая матрица:");
        PrintMatrix(resultMatrix);
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new ArgumentException("Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;

                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

