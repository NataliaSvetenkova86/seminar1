 //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("row= ");
int row = int.Parse(Console.ReadLine());
Console.Write("col= ");
int col = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];

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

 
 
int[,]  GetDecreasingArray(int[,] array)
{
      for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SortArray(array,i);
        }
      }
     return array;
}
 int[,] SortArray(int[,] array,int i)
{
 for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
 return array;
}

int[,] myArray = GetArray(row, col, 0, 10);
int[,] decreasingArray = GetDecreasingArray(myArray);
 
Console.WriteLine();
 
 
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Массив с элементами по убыванию");
PrintArray(decreasingArray);

 