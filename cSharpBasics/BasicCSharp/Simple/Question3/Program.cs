using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a degree of Celcius: ");
        double celcius=(double.Parse(Console.ReadLine()));
        double farh;
        farh=(celcius*(9/5))+32;
        double Total=Math.Round(farh,2);
        System.Console.WriteLine($"Fahrenheit Scale:{Total}");
    }
}
