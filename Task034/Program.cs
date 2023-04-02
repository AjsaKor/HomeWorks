// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int count = 0;
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
Console.WriteLine($"В массиве {count} четных чисел");

void FillArray(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
