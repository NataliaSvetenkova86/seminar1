// Pадайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
Console.WriteLine ("Введите  размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите минимальное трехзначное число массива");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите максимальное трехзначное число массива");
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
Console.WriteLine (String.Join (" ", GetArray(size, minValue, maxValue)));

int Even(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2 == 0))
        {
            count++;

        }
    }
    return count;
}

Console.WriteLine($"{Even(arr)}");