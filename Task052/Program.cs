// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Не знаю, как исправить ошибку.  Выдает: 
//Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
// 11 и 22 строки.

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(array2d);
Console.WriteLine($"Среднее арифметическое столбца: {AverageValueColumn(array2d)}");


double AverageValueColumn(int[,] matrix)
{
    double[] averageValueColumn = new double [matrix.GetLength(1)]; 
    double sumColumn = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageValueColumn[matrix.GetLength(1)] = (sumColumn + matrix[i, j]) / matrix.GetLength(0);
        }
    }
     return averageValueColumn[matrix.GetLength(1)];
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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