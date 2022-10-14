using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int count=0;
        double sum=0,squares;
        System.Console.WriteLine("Enter a starting number:");
        int initial=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a End value : ");
        int end=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("numbers:");
        while(initial<=end)
        {
         System.Console.WriteLine($"{initial}");
         count++;
         squares =(Math.Pow(initial,2));
         sum= sum + squares;
         initial++;
        }
        System.Console.WriteLine($"count is {count}");
        System.Console.WriteLine($"output is {sum}");
        
    }
}
  

