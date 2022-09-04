// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
  
 
Console.Write("Введите размер матриц: ");
int size = int.Parse(Console.ReadLine());
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixC = new int[size, size];


int[,] GetArray(int[,] result)
 {
      for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

  
int[,] ProductMultip(int[,] matrixA, int[,] matrixB, int[,] matrixC)
 {
    for (int i = 0; i < size; i++)
      {
        for (int j = 0; j < size; j++)
         {
           for (int k = 0; k < size; k++)
            {
              matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
         }
      }
   return matrixC;
 }




GetArray(matrixA);
GetArray(matrixB);

Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();

Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();

Console.WriteLine("Произведение матриц А*В");
PrintArray(ProductMultip(matrixA, matrixB, matrixC));
 
 

 
