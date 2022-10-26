using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number:");
        int value;
        bool integer=(int.TryParse(Console.ReadLine(),out value));
        double inch=2.54;
        double centimter;
        if(integer)
        {
            centimter=value*inch;
            System.Console.WriteLine($"Centimeter{centimter}");
        }
        else
        {
            System.Console.WriteLine("Invalid Input");
        }
    }
}