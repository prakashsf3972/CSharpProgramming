using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your choice: \n A.TEA \n B.COFFEE \n C.MILK \n");
        char choice=(char.Parse(Console.ReadLine().ToUpper()));
        switch(choice)
        {
            case 'A':
           {
              System.Console.WriteLine("Tea Selected");
             break;
            }
            case 'B':
            {
               System.Console.WriteLine("Coffee selected");
               break;
            }
            case 'C':
            {
                System.Console.WriteLine("Milk selected ");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;

            }

        }

//using interger:

        System.Console.WriteLine("Enter your choice: \n 1.TEA \n 2.COFFEE \n 3.MILK \n");
        int choice2=(int.Parse(Console.ReadLine()));
        switch(choice2)
        {
            case 1:
           {
              System.Console.WriteLine("Tea Selected");
             break;
            }
            case 2:
            {
               System.Console.WriteLine("Coffee selected");
               break;
            }
            case 3:
            {
                System.Console.WriteLine("Milk selected ");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;

            }

        }
    



//using string

        System.Console.WriteLine("Enter your choice: ");
        string choice3=(Console.ReadLine().ToUpper());
        switch(choice3)
        {
            case "TEA":
           {
              System.Console.WriteLine("Tea Selected");
             break;
            }
            case "COFFEE":
            {
               System.Console.WriteLine("Coffee selected");
               break;
            }
            case "MILK":
            {
                System.Console.WriteLine("Milk selected ");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;

            }

        }
    }
}

    
