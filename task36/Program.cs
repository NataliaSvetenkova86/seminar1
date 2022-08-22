// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
Console.WriteLine ("Введите  размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите минимальное  число массива");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите максимальное  число массива");
int maxValue = int.Parse(Console.ReadLine());
int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for ( int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
int[] arr = GetArray(size, minValue, maxValue);
Console.WriteLine (String.Join (" ", arr));

int ResultArrey(int[] arr)
{
Console.WriteLine (String.Join (" ", arr));
    int res = 0;
    for (int i= 1; i < arr.Length; i++)
    {
        if (i % 2 ==1)
        {
          res += arr[i];
        }     
    }
   return res;
}

Console.WriteLine($"{ResultArrey(arr)}");


