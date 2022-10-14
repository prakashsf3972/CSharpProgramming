using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        double meter,centimeter,mile;
        System.Console.WriteLine("Enter a Length value :");
        meter = (double.Parse(Console.ReadLine()));
        
        centimeter=meter * 100;

        mile=0.0006213715277778 * meter;
        
        System.Console.WriteLine($"Centimter = {centimeter}");
        System.Console.WriteLine($"Millimeter - {centimeter*10}");
        System.Console.WriteLine($"Inch - {39.3 *meter}");
        System.Console.WriteLine($"Foot - {12 * meter}");
        System.Console.WriteLine($"Mile - {mile}");
        
         
        
    }
}
