using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a 1st number: ");
        int number1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a 2nd number :");
        int number2=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a 3rd Number :");
        int number3=(int.Parse(Console.ReadLine()));

        if(number1 > number2)
        {
            System.Console.WriteLine($"{number1} is the greatest amoung three values");
        }
        else if(number1 < number2)
        {
            System.Console.WriteLine($"{number2} is the greatest amoung three values");
        }
        else
        {
            System.Console.WriteLine($"{number3} is the greatest amoung three values");
        }
    }
}
