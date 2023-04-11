// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> ");
NaturalNumbers(number);
if (number < 1)
{
    Console.WriteLine("Ввели не натуральное число");
}

void NaturalNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}