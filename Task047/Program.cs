// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double [,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(min, max + 1)) / 10;
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndInt(3, 4, -1000, 1000);
PrintMatrix(array2d);