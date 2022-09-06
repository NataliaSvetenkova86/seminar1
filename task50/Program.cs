// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

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
Console.Write("введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.Write("введите номер столбца ");
int b = int.Parse(Console.ReadLine());

 void SearchArrey(int[,] array, int a, int b )
{
    if( a < array.GetLength(0) && b < array.GetLength(1))
    {
     Console.WriteLine ($"{array[a,b]}");
    }
    else{
        Console.WriteLine ($"Такого числа в массиве нет");
    }
} 
int[,] myArray = GetArray(m, n, 0, 100);
PrintArray(myArray);
 SearchArrey(myArray,a,b);