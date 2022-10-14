using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a value 1");
        int a = (int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a value 2");
        int b = (int.Parse(Console.ReadLine()));
//
        double Output=(a*a+2*a*b+b*b);
        System.Console.WriteLine($"Output = {Output}");
    }
}
