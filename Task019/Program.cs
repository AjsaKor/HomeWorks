// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = PalindromNum(number);
if (result == false)
{
     Console.WriteLine($"Число {number} - не является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} - палиндром");
}


bool PalindromNum(int num)
{
    int digit1 = num / 10000;
    int digit5 = num % 10;
    int digit2 = num % 10000 / 1000;
    int digit4 = num % 100 / 10;
    bool result = digit1 == digit5 && digit2 == digit4;
    return result;
}