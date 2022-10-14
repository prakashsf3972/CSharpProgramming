using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
     System.Console.WriteLine("Enter a fibonacci series: ");
     int series=(int.Parse(Console.ReadLine()));
     System.Console.WriteLine("Enter your starting value:");
     int first=(int.Parse(Console.ReadLine()));
      System.Console.WriteLine("Enter your second value:");
     int second=(int.Parse(Console.ReadLine()));
     int sum;
     series=series-2;
     System.Console.WriteLine("Fibonacci Series numbers are: ");
     System.Console.WriteLine($"{first} \n{second}");
     Fibonacci1(series,first,second);

        
     void Fibonacci1(int series,int first,int second)
     {
        while(series>0)
        {
         sum=first+second;
         first=second;
         second=sum;
         System.Console.WriteLine($"{sum}");   
         series--; 
        }
    }

    }
}

