//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Exponentiation(double number, double degree)
{
   return Math.Pow(number, degree);
}

Console.WriteLine("Please, enter your number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, enter degree of number: ");
double degree = Convert.ToDouble(Console.ReadLine());

double result = Exponentiation(number, degree);
Console.WriteLine($"{number} in a {degree} degree equals - {result}");


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int number)
{
   int sum = 0;
   while(number>0)
   {
      sum +=number%10;
      number/=10;
   }
   return sum;
}

Console.WriteLine("Please, enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(number);

Console.WriteLine($"The summary of digits in number {number} equals - {result}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
   int[] arrayOfInt = new int[size];
   for (int i=1; i<=size; i++)
   {
      Console.WriteLine($"Please, enter {i} number for array");
      arrayOfInt[i-1] = Convert.ToInt32(Console.ReadLine());
   }
   return arrayOfInt;
}

void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]);
      if(i == array.Length-1) Console.Write(".");
      else Console.Write(", ");
   }
}

Console.WriteLine("Please, enter size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
if(size>0)
{
   int[] arrayOfInt = CreateArray(size);
   ShowArray(arrayOfInt);
}else
   Console.WriteLine("Can't create array with such size. It needs to be more than 0");