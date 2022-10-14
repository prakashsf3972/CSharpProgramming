using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number : ");
        int number=(int.Parse(Console.ReadLine()));
        
        if (number % 2 == 0)
        {
            System.Console.WriteLine($"{number} is an Even Number");
        }
        else
        {
            System.Console.WriteLine($"{number} is an Odd Number");
        }
    }
}
