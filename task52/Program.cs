// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());
Console.Write("m= ");
int m = int.Parse(Console.ReadLine());

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
string AverageArray(int[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(1); i++)
    {
    double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
               
                sum += array[j, i];
            
        }
        
      result +=  Convert.ToString(Math.Round(sum /array.GetLength(0),1)) + "; ";
    }
    return result;
}
Console.WriteLine($"{AverageArray(myArray)}");