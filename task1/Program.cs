// Задача 25. Напишите цикл, который принимает на вход два числа (А и B) и возводит число А в натуральную степень B

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int involution = Involution (numA, numB);
Console.WriteLine("Возведение А в степени B = " + involution);


int Involution (int numA, int numB)
{
    int result = 1;
    for(int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}


// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = Sum(num);
Console.WriteLine("Сумма чисел = " + sum);

  int Sum(int num){
    
    int count = Convert.ToString(num).Length;
    int N = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      N = num - num % 10;
      result = result + (num - N);
      num = num / 10;
    }
   return result;
  }


  // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Add (i) + ",");
 }
Console.Write("]");

int Add (int a)
{
    return numbers[a];
}



