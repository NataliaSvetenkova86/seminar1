int num = new Random().Next();
int a = num%1000;
int b = num%100;
int resalt = (a-b)/100;
if (num > 99)
{
    Console.WriteLine( $"{resalt} числа {num}" );
}
else
{
    Console.WriteLine( $"третьей цифры числа {num} нет" );
}
    
