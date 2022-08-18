Console.WriteLine ("Введите число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число");
int B = int.Parse(Console.ReadLine());

int GetPow()
{
    int pow = 1;
   
    for ( int i = 1; i <= B; i++)
    {
        pow = pow*A;
    }
    return pow;
}
Console.WriteLine(GetPow());