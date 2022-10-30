using System;
namespace Test1;

    class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a 1st Number: ");
            //Get input1 from the user
        int value1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter a 2nd Number: ");
            //get input2 from the user
        int value2=int.Parse(Console.ReadLine());
        //Addition
        System.Console.WriteLine("Addition of Two Numbers is: "+value1+value2);
        //Subtraction
        System.Console.WriteLine($"Subtraction of Two Numbers is :{value1-value2}");
        //Multiplication
        System.Console.WriteLine($"Multiplication of Two Numbers is: {value1 * value2}");
        //Division
        System.Console.WriteLine($"Division of Two Numbers is :{value1/value2}");
        //Modulus
        System.Console.WriteLine($"Modulus of Two Numbers is:{value1 % value2}");
    }
}

