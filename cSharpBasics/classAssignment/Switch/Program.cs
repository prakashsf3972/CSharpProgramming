using System;
namespace Switch;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ENTER A VALUE 1 : ");
        int value1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("ENTER A VALUE 2 : ");
        int value2=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("ENTER YOUR CHOICE : \n 1.(+) Addition \n 2.(-) Subtraction \n 3.(*)Multiplication \n 4.(/)Division \n 5.(%)Modulus");
        System.Console.WriteLine("Pick your Choice as an Arithmetic values : ");
        char choosen=(char.Parse(Console.ReadLine()));

        switch(choosen)
        {
            case '+':
            {
              System.Console.WriteLine($"Addition {value1+value2}");
              break;
            }
            case '-':
            {
                System.Console.WriteLine($"Subraction {value1-value2}");
                break;
            }
            case '*':
            {
                System.Console.WriteLine($"Multiplication {value1 * value2}");
                break;
            }
            case '/':
            {
                System.Console.WriteLine($"Division {value1 / value2}");
                break;
            }
            case '%':
            {
                System.Console.WriteLine($"Modulus {value1 % value2}");
                break;
            }
        }
    }
}
