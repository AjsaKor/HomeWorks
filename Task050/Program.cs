// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(array2d);

Console.WriteLine("Введите номер строки: ");
int myRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int myColumn = Convert.ToInt32(Console.ReadLine());

if(myRow > 0 && myColumn > 0) 
{
    if (myRow < rows && myColumn < columns) 
    Console.WriteLine($"Искомый элемент: {array2d[myRow, myColumn]}");
    else Console.WriteLine("Таких координат нет.");
}
else Console.WriteLine("Таких координат нет.");


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

