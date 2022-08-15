
Console.WriteLine ("Введите  трехзначное число");
int num = int.Parse(Console.ReadLine());;
int a = num%100; 
int b = num% 10 ;
int resalt = (a-b)/10;
Console.WriteLine($"{resalt} числа {num}");