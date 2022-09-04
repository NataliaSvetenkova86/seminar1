// See https://aka.ms/new-console-template for more information
//Задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            double tmp = new Random().Next(minValue, maxValue + 1);
            result[i, j] = tmp / 10;
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
double[,] myArray = GetArray(m, n, -100, 100);
PrintArray(myArray);