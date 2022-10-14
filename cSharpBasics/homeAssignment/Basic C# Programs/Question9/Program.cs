using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a vehicle Speed km/hr : ");
        int speed =(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Time consumed in sec : ");
        int time = (int.Parse(Console.ReadLine()));

        double Output =(speed * time * 5/18);

        System.Console.WriteLine($"Distance Travalled = {Output} Meters");
        
    }
}
