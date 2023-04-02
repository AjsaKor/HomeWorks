// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int numExp = NumExp(numberA, numberB);
  Console.WriteLine($"Ответ: {numExp}");

int NumExp(int numA, int numB){
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }
    return result;
}



 

