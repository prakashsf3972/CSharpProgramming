using System;
namespace ForLoop;
class Program
{
public static void Main(string[] args)
{
    int i;
    for(i=1;i<25;i++)
    {
        if((i % 2) == 0)
        {
            System.Console.WriteLine($"Even numbers : {i} ");
        }

    }
    System.Console.WriteLine("Enter a initization number :");
    int initial=(int.Parse(Console.ReadLine()));
    System.Console.WriteLine("Enter a breaking Point number : ");
    int final=(int.Parse(Console.ReadLine()));

//SUM OF SQUARE

int Total = 0;
int sumofsquares = 0;
for(i=initial;i<=final;i++)
{
  sumofsquares = i * i;
  Total=Total+sumofsquares;
}
System.Console.WriteLine($"Sum of the squares : {Total}");
   
}
}
