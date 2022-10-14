using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        string statement;
        int input;
        do
        {
            System.Console.WriteLine("Enter a Input: ");
            input=(int.Parse(Console.ReadLine()));
            if(input%2==0)
            {
                System.Console.WriteLine("The given input is even");
            }
            else
            {
                System.Console.WriteLine("The given input is Odd");
            }
            System.Console.WriteLine("Do you want to Continue Give YES or Give NO ");
            statement=(Console.ReadLine().ToLower());
            
        }while(statement =="yes");


    }
}
