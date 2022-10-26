using System;
namespace TryParse;
class Progran
{
    public static void Main(string[] args)
    {
        int Number=6;
        System.Console.Write("Enter a value :");
        bool a=int.TryParse(Console.ReadLine(),out Number);
        System.Console.WriteLine("The number value is"+Number);
        System.Console.WriteLine("The boolean is "+a);


    }
}