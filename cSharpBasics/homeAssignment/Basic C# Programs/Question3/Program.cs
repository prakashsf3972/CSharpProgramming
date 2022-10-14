using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ENTER THE AMOUNT OF CELSIUS");
        double celsius=(double.Parse(Console.ReadLine()));
        
        double kelvin=(celsius + 273.15);
        
        double fahrenheit=(celsius * 9/5) + 32 ;

        System.Console.WriteLine($"Kelvin = {Math.Round(kelvin,2)}");
        System.Console.WriteLine($"Fahrenheit = {fahrenheit}");

    }
}