using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a First Number : ");
        int num1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Second number : ");
        int num2=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Here are options :");
        System.Console.WriteLine("1.Addition \n 2.Subtraction \n 3.Multiplication  \n 4.Division \n 5.Exit");
        System.Console.WriteLine("Enter Your choice : ");
        int choice =(int.Parse(Console.ReadLine()));
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"The addition of {num1} and {num2} is {num1+num2}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The subtraction of {num1} and {num2} is {num1-num2}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The Multiplication of {num1} and {num2} is {num1 *num2}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The Multiplication of {num1} and {num2} is {num1 / num2}");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exit");
                break;
            }
        }
    }
}
