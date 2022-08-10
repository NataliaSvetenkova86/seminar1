Console.WriteLine ("Введите число соответсвующее дню недели");
int num = int.Parse(Console.ReadLine());
if ((num == 6) || (num == 7))
{
    Console.WriteLine("выходной");
}

else if(num < 6)
{
Console.WriteLine("будний");
    
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}