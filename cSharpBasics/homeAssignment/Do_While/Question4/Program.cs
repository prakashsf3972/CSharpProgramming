using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        int value;
        bool integer;
        do
        {
            System.Console.WriteLine("Enter a number:");
            integer=(int.TryParse(Console.ReadLine(),out value));
            if((value<=10)&&(value>0))
            {
            System.Console.WriteLine("Enter number is Valid:");
            System.Console.WriteLine($"The number is {value}");
            }
            else{
                integer = false;
            }
        }while(!integer);
    }
}
