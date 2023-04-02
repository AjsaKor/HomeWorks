// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
if(arraySize <= 0)
{
Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
return;
}
int[] arr = CreateArray(arraySize);
PrintArray(arr);
Console.Write("-> [");
PrintArray(arr);
Console.Write("]");

int[] CreateArray(int arrayLength)
{
int[] newArray = new int[arrayLength];
Random random = new Random();
for(int i = 0; i < arrayLength; i++)
{
newArray[i] = random.Next(0, 101);
}
return newArray;
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}" + " ");
}
}