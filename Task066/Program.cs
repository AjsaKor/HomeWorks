// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим последнее число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || m < 1)
{
    Console.WriteLine("Ввели не натуральное число");
}

else {
Console.Write($"Сумма натуральных чисел равна: {NaturalNumbersSum(m, n)}");

NaturalNumbersSum(m, n);
}

int NaturalNumbersSum(int num1, int num2)
{   int sum = num1;
    if(num1 > num2) 
    { 
        return sum = num1 + NaturalNumbersSum(num1 - 1, num2);
    }
    else if (num1 < num2) 
    {
    return sum = num1 + NaturalNumbersSum(num1 + 1, num2);
    }
    else return num1;
}