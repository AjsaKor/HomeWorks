// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.


int GetThirdDigit(int number)
{
   int result = -1;
   if (number > 99)
   {
    while (number < 1000)
    {
         number = number / 10;
    }
         result = number % 10; 
   }
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetThirdDigit(number);
if (GetThirdDigit(number) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа -> {result}");



