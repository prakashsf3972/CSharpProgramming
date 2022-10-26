using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of Terms: ");
        int terms=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter the First number:");
        int first=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter the Second number:");
        int Second=(int.Parse(Console.ReadLine()));
        int count=2,series;
        System.Console.WriteLine($"Fibonacci Series are: \n{first}");

        while(count<terms)
        {
            series=first+Second;
            first=Second;
            Second=series;
            count++;
            System.Console.WriteLine(+series);
        }


    }
}
