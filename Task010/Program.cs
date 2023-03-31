// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetSecondDigit(number);
Console.WriteLine($"Вторая цифра числа -> {result}");

int GetSecondDigit(int number)
{
   return number / 10 % 10;
}
