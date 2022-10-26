using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number:");
        double radious=(double.Parse(Console.ReadLine()));
        System.Console.WriteLine($"Area = {3.14*radious*radious}");
        System.Console.WriteLine($"Perimeter= {2*3.14*radious}");
    }
}
