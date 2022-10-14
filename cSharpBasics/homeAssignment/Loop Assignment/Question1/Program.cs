using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
     System.Console.WriteLine("Enter a initial number : ");
     int initial =(int.Parse(Console.ReadLine()));
     System.Console.WriteLine("Enter a End Number :");
     int End =(int.Parse(Console.ReadLine()));
     for(;initial<=End;initial++)
     {
        {
            System.Console.WriteLine($"{initial}");
        }
     }
    }
}

