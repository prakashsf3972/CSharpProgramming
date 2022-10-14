using System;
namespace Question2;
class Problem
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the First Number : ");
        double  value1=(Double.Parse(Console.ReadLine()));
        System.Console.WriteLine("Input the second Number : ");
        double value2=(Double.Parse(Console.ReadLine()));
//ADDITION
        System.Console.WriteLine($"Addition of two values : {value1 + value2}");
//SUBTRACTION
        System.Console.WriteLine($"Subtraction of two values : {value1 - value2} ");
//MULTIPLICATION
        System.Console.WriteLine($"Multiplication of two values : {value1 * value2}");
//DIVISION
        System.Console.WriteLine($"Division of two values : {(Math.Round(value1 / value2,2))} ");
//MODULUS
        System.Console.WriteLine($"Modulus of two Values : {value1 % value2} ");
        
    }
}
