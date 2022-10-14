using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a radious of a cirle :");
        int radious =(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("choose your Compute : \n 1.Area \n2.Perimter \n3.Diameter of a circle");
        int choice =(int.Parse(Console.ReadLine()));
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"Area : {3.14*radious*radious}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"Perimeter : {2 * 3.14 * radious}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"Diameter of Circle : {2 * radious}");
                break;
            }
        }
    }
}
