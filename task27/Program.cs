Console.WriteLine ("Введите число");
int a = int.Parse(Console.ReadLine());

int Sum (int a)
{
   if(a<0)
    {
      Console.WriteLine ("Введите число от 0");        
    }
    int sum = 0;
    int a1 = 0;
  
   while(a > 0)
    {
     if(a > 9)
      {
        a1 = a%10;
        a = a/10;
        sum = sum + a1;
      }
     else 
      {
        sum = sum  + a;
        a = a/10;
      }
    } 
   return sum;
}
Console.WriteLine(Sum(a));