// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
  
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

 void GetSumArray(int[,] array)
{
     
    int minSum = GetSum(array, 0);
    int stringNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = GetSum(array, i);
        
         if (sum < minSum)
           {
             minSum = sum;
             stringNumber++;
           }
    }
   Console.WriteLine($"Cтрока номер: {stringNumber} , с наименьшей суммой элементов равной:   {minSum}");
}
 int GetSum(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum = sum + array[i, j]; 
  }
  return sum;
}
 

int[,] myArray = GetArray(row, col, 0, 10);
 
 
Console.WriteLine();
  
PrintArray(myArray);
Console.WriteLine();
GetSumArray(myArray);
 
 

 