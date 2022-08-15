Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
if (num<10000 || num>99999)
{
    Console.WriteLine("число не соответвует заданию");
    return;
}
int a = num%100;
int a2 = a%10;
int a3 = a/10;
int c = a2*10 + a3;
int b = num/1000;
if (b==c)
{
    Console.WriteLine ($"число {num} палиндромом");
}
else
{
    Console.WriteLine ($"число {num} не  является палиндромом"); 
}