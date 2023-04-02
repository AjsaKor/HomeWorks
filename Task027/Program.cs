// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите целое число : ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе: {sumDigits}");

int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}


