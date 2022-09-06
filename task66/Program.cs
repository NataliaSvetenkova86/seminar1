//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 
Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());


int GetSum (int m, int n, int sum)
{
  if (m > n) 
  {
    return sum;
  }
  else {
  sum = sum + (m++);
  sum = GetSum(m, n, sum);
  }
   return sum;
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {GetSum(m, n, 0)}"); 