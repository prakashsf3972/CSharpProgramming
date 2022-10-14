using  System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a Radious : "); 
       double r=(double.Parse(Console.ReadLine() ));

       System.Console.WriteLine("Enter a height : ");
       double h=(double.Parse(Console.ReadLine() ));

       double volume=(3.14*r*r*h);
       System.Console.WriteLine($"Volume : {Math.Round(volume,2)}");
    }
}
