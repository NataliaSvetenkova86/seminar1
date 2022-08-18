Console.WriteLine ("Введите число");
int N = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число");
int B = int.Parse(Console.ReadLine());
void RandArrey()
{
    int [] arr = new int[N];
    for( int i=0; i<N; i++)
    {
        arr[i] = new Random{}.Next(A,B);
    }
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write("{0} ", arr[i]);
    }

}
RandArrey();