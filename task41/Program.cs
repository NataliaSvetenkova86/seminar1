//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine ("Размер массива");
int M = int.Parse(Console.ReadLine());
int[] GetArray(int M) 
{
    int[] res = new int[M];
    for ( int i = 0; i<M; i++)
     {
        Console.Write ($"Введите число:  ");
        int temporary = int.Parse(Console.ReadLine());
        res[i] = temporary;  
     }
    
    return res;
};
int[] arr = GetArray(M);
Console.WriteLine (String.Join (" ", arr));

int GetCount(int []arr) 
{
    int count = 0;
    for ( int i = 0; i<arr.Length; i++)
     {
        if(arr[i] > 0 )
         {
           count++;
         }
     }
    return count;
};

Console.WriteLine ($"Чисел больше нуля: {GetCount(arr)}");