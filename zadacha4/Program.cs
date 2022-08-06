Console.Write("число a = ");
int numberA = int.Parse( Console.ReadLine());
Console.Write ("число b = ");
int numberB = int.Parse( Console.ReadLine());
Console.Write ("число c = ");
int numberC = int.Parse( Console.ReadLine());
int max = numberA;
if (numberA>max) max = numberA;
if (numberB>max) max = numberB;
if (numberC>max) max = numberC;
Console.WriteLine($"максимальное число равно {max}");

