Console.Write("число a = ");
int numberA = int.Parse( Console.ReadLine());
if (numberA > 0 )
{

if ( numberA % 2 ==0 ) 
{
Console.WriteLine ($"число {numberA}  четное");
}
else {
    Console.WriteLine($"число {numberA} нечетное");
}
}
else {
     Console.WriteLine(" введите число больше 0");
}