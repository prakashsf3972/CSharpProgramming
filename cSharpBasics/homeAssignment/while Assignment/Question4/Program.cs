using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter a number: ");
        bool integer=(int.TryParse(Console.ReadLine(),out number));
        while(!integer)
        {
            System.Console.WriteLine("Enter a Valid Input");
            integer=(int.TryParse(Console.ReadLine(),out number));
            while(integer)
            {
                if(number>5 || number<0)
                {
                    System.Console.WriteLine("You enter a valid format. But it out of range between 1-5.");
                    integer=int.TryParse(Console.ReadLine(),out number);
                }
                else
                {
                    System.Console.WriteLine($"Input valid .The output is {number}");
                    break;
                }
            }
        }
        
    }
}
