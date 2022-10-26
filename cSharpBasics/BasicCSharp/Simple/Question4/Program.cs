using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Input :");
        double currency=double.Parse(Console.ReadLine());
        System.Console.WriteLine($"USD currency is:{(currency/100)*1.22}");
        System.Console.WriteLine($"EUR currency is:{((currency/100)*1.27)}");
        System.Console.WriteLine($"CNY currency is:{((currency/100)*8.79)}");
    }
}
