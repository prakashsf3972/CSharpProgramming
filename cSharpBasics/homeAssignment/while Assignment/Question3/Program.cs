using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int series=0;
        int count=2;
        System.Console.WriteLine("Enter No of terms: ");
        int terms=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Fibonacci Series");
        int first_value=0;
        int second_value=1;
        System.Console.WriteLine($"{first_value} \n{second_value}");
        while(count<terms)
        {
          series=first_value+second_value;
          System.Console.WriteLine($"{series}");
          first_value=second_value;
          second_value=series;
          count++;
          
        }
        
    }
}
