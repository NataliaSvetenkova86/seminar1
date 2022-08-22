// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
Console.WriteLine ("Введите  размер массива");
int size = int.Parse(Console.ReadLine());
 
double [] GetArray(int size) 
{
    double[] res = new double[size];
    for ( int i = 0; i<size; i++)
    {
        Console.WriteLine ($"Введите целочисленное число индекс: {i} ");
        double temporary = double.Parse(Console.ReadLine());
         res[i] = temporary;  
    }
    
    return res;
};
double [] arr = GetArray(size);
Console.WriteLine (String.Join (" ", arr));

double ResultArrey(double[] arr)
{
    double min = arr[0];
    double max = arr[1];
 for ( int i = 0; i<arr.Length; i++)
    {
      if(arr[i] > max)
        {
           max = arr[i];
        }
      else if(arr[i] < min)
       {
         min = arr[i];
       }
    }
return max - min;  
}
Console.WriteLine($"{ResultArrey(arr)}");
