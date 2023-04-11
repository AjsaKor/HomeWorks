// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк 1-й матрицы: ");
int rowsFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-й матрицы: ");
int columnsFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива 1-й матрицы: ");
int minFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива 1-й матрицы: ");
int maxFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2-й матрицы: ");
int rowsSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-й матрицы: ");
int columnsSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива 2-й матрицы: ");
int minSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива 2-й матрицы: ");
int maxSecond = Convert.ToInt32(Console.ReadLine());
int[,] array2dFirst = CreateMatrixRndInt(rowsFirst, columnsFirst, minFirst, maxFirst);
PrintMatrix(array2dFirst);
Console.WriteLine();
int[,] array2dSecond = CreateMatrixRndInt(rowsSecond, columnsSecond, minSecond, maxSecond);
PrintMatrix(array2dSecond);
int[,] resultMatrix = Array2dResult(array2dFirst, array2dSecond);

if (columnsFirst != rowsSecond)
{
  Console.WriteLine("Ошибка. Эти матрицы нельзя перемножить.");
  return;
}
else
{
Console.WriteLine("Произведение первой и второй: ");
PrintMatrix(resultMatrix);
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
            Console.Write($"{matrix[i, j], 10}");
        }
       Console.WriteLine("|");
    }
}

int[,] Array2dResult (int[,] array2dFirst, int[,] array2dSecond)
{
  int[,] array2dResult = new int[array2dFirst.GetLength(0), array2dSecond.GetLength(1)];

  for (int i = 0; i < array2dFirst.GetLength(0); i++)
  {
    for (int j = 0; j < array2dResult.GetLength(1); j++)
    {
      for (int k = 0; k < array2dFirst.GetLength(1); k++)
      {
        array2dResult[i,j] += array2dFirst[i,k] * array2dSecond[k,j];
      }
    }
  } return array2dResult;
}