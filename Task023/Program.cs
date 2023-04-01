// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);

void TableCube(int number)
{
    int count = 1;
    while (count <= number)
    {
        int cube = count * count * count;
        Console.WriteLine($"{count, 3} -> {cube, 6}");
        count++;
    }
}